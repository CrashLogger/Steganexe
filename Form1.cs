using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace ImageSteganography
{
    public partial class Form1 : Form
    {

        static Bitmap originalImage;
        static string originalImagePath;

        public Bitmap editImage;

        public Form1()
        {
            InitializeComponent();
        }

        public void openAnImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = ("Images (*.png; *.gif; *.bmp) | *.png; *.gif; *.bmp");
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Image chosen: ");
                Console.WriteLine(fileDialog.FileName);

                originalImage = new Bitmap(fileDialog.FileName);
                originalImagePath = fileDialog.FileName;
            }
            else
            {
                Application.Exit();
                Environment.Exit(0);
            }

            Size newSize = checkSize(originalImage.Size);
            ImagePreview.Size = newSize;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            openAnImage();

            //Sets the image preview
            ImagePreview.SizeMode = PictureBoxSizeMode.Zoom;
            ImagePreview.Image = originalImage;

            //Some other fancy shit to keep the UI clean
            Size = new Size(ImagePreview.Size.Width + 400, ImagePreview.Size.Height + 10);
            MessageGroup.Location = new Point(ImagePreview.Size.Width + 16, 5);
            MessageGroup.Size = new Size(Size.Width - 16 - (ImagePreview.Size.Width + 32), 50);
            CypherBox.Location = new Point(ImagePreview.Size.Width + 16, MessageGroup.Size.Height + 16);
            CypherBox.Size = new Size(Size.Width - 16 - (ImagePreview.Size.Width + 32), 350);
            ApplyButton.Location = new Point(CypherBox.Location.X + CypherBox.Size.Width - 100, CypherBox.Location.Y + CypherBox.Size.Height + 10);
            SaveButton.Location = new Point(ApplyButton.Location.X - 105, ApplyButton.Location.Y);
            DecodeButton.Location = new Point(ImagePreview.Width + 16, ApplyButton.Location.Y);
            //These need to be limited to a byte's size because they're read from a single pixel's RGB values
            GapNumber.Maximum = 255;
            infopointSize.Maximum = 255;
        }

        public Size checkSize(Size oldSize)
        {
            int i = 1;
            Size trySize = oldSize;
            while (trySize.Width > 1200 || trySize.Height > 920)
            {
                trySize.Width = oldSize.Width / i;
                trySize.Height = oldSize.Height / i;
                i++;
            }
            Console.WriteLine("Preview downscaled " + i + " times!");
            return (trySize);
        }

        private void CheckPixel(int i, int j)
        {
            Color pixel = originalImage.GetPixel(i, j);
            Console.WriteLine(pixel.R.ToString());
            byte tmp = Convert.ToByte(pixel.R.ToString());
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            cypherHeaders();
            cypherText();
        }


        public void cypherHeaders()
        {
            editImage = originalImage;
            editImage.SetPixel(0, 0, Color.FromArgb(255, Convert.ToInt32(infopointSize.Value), Convert.ToInt32(GapNumber.Value), 0));
            editImage.SetPixel(originalImage.Width - 1, originalImage.Height - 1, Color.FromArgb(255, Convert.ToInt32(infopointSize.Value), Convert.ToInt32(GapNumber.Value), 0));
            ImagePreview.Image = editImage;
        }

        public void cypherText()
        {
            string msgstring = MessageTextBox.Text;
            byte[] msg = Encoding.ASCII.GetBytes(msgstring);
            int i = 0;
            int Xmove = 1;
            int Ymove = 1;

            while (i < msg.Length)
            {
                Console.WriteLine(msg[i]);
                byte R = Convert.ToByte(msg[i]);
                Console.WriteLine(msg[i + 1]);
                byte G = Convert.ToByte(msg[i + 1]);
                Console.WriteLine(msg[i + 2]);
                byte B = Convert.ToByte(msg[i + 2]);
                if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(originalImage.Size.Width);
                    Console.WriteLine(Xmove * Convert.ToInt32(GapNumber.Value));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(originalImage.Size.Height);
                    Console.WriteLine(Ymove * Convert.ToInt32(GapNumber.Value));
                    Console.ForegroundColor = ConsoleColor.White;
                    if (Ymove * Convert.ToInt32(GapNumber.Value) >= originalImage.Height)
                    {
                        MessageBox.Show($@"The program ran out of image to encode information inside of. Encoded a total of: {i} characters.", "Ran out of image!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        for (int n = 0; n < infopointSize.Value; n++)
                        {
                            editImage.SetPixel(Xmove * Convert.ToInt32(GapNumber.Value), Ymove * Convert.ToInt32(GapNumber.Value), Color.FromArgb(255, R, G, B));
                            editImage.SetPixel(Xmove * Convert.ToInt32(GapNumber.Value), Ymove * Convert.ToInt32(GapNumber.Value) + Convert.ToInt32(infopointSize.Value), Color.FromArgb(255, R, G, B));
                            editImage.SetPixel(Xmove * Convert.ToInt32(GapNumber.Value) + Convert.ToInt32(infopointSize.Value), Ymove * Convert.ToInt32(GapNumber.Value), Color.FromArgb(255, R, G, B));
                            editImage.SetPixel(Xmove * Convert.ToInt32(GapNumber.Value) + Convert.ToInt32(infopointSize.Value), Ymove * Convert.ToInt32(GapNumber.Value) + Convert.ToInt32(infopointSize.Value), Color.FromArgb(255, R, G, B));
                        }

                    }
                    catch
                    {

                    }
                }
                i = i + 3;
                if (Xmove * Convert.ToInt32(GapNumber.Value) >= originalImage.Size.Width)
                {
                    Console.WriteLine("Too long");
                    Xmove = 1;
                    Ymove++;
                }
                else
                {
                    Xmove++;
                }
            }
        }
        public void SaveButton_Click(object sender, EventArgs e)
        {
            string newImagePath = originalImagePath.Substring(0, (originalImagePath.Length - originalImagePath.Split(Path.DirectorySeparatorChar).Length));
            newImagePath = newImagePath + ".png";
            Console.WriteLine(newImagePath);
            editImage.Save(newImagePath);
        }
    }
}
