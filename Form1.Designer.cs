
namespace ImageSteganography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            this.MessageGroup = new System.Windows.Forms.GroupBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.CypherBox = new System.Windows.Forms.GroupBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.infopointSize = new System.Windows.Forms.NumericUpDown();
            this.GapLabel = new System.Windows.Forms.Label();
            this.GapNumber = new System.Windows.Forms.NumericUpDown();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.MessageGroup.SuspendLayout();
            this.CypherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infopointSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GapNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePreview
            // 
            this.ImagePreview.Location = new System.Drawing.Point(0, 0);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Padding = new System.Windows.Forms.Padding(30);
            this.ImagePreview.Size = new System.Drawing.Size(450, 500);
            this.ImagePreview.TabIndex = 0;
            this.ImagePreview.TabStop = false;
            // 
            // MessageGroup
            // 
            this.MessageGroup.Controls.Add(this.MessageTextBox);
            this.MessageGroup.Location = new System.Drawing.Point(456, 12);
            this.MessageGroup.Name = "MessageGroup";
            this.MessageGroup.Size = new System.Drawing.Size(336, 50);
            this.MessageGroup.TabIndex = 1;
            this.MessageGroup.TabStop = false;
            this.MessageGroup.Text = "Message";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(7, 20);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(323, 20);
            this.MessageTextBox.TabIndex = 0;
            // 
            // CypherBox
            // 
            this.CypherBox.Controls.Add(this.SizeLabel);
            this.CypherBox.Controls.Add(this.infopointSize);
            this.CypherBox.Controls.Add(this.GapLabel);
            this.CypherBox.Controls.Add(this.GapNumber);
            this.CypherBox.Controls.Add(this.KeyLabel);
            this.CypherBox.Controls.Add(this.KeyTextBox);
            this.CypherBox.Location = new System.Drawing.Point(456, 68);
            this.CypherBox.Name = "CypherBox";
            this.CypherBox.Size = new System.Drawing.Size(336, 400);
            this.CypherBox.TabIndex = 2;
            this.CypherBox.TabStop = false;
            this.CypherBox.Text = "Cypher";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(171, 61);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(68, 13);
            this.SizeLabel.TabIndex = 6;
            this.SizeLabel.Text = "InfopointSize";
            // 
            // infopointSize
            // 
            this.infopointSize.Location = new System.Drawing.Point(170, 77);
            this.infopointSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.infopointSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.infopointSize.Name = "infopointSize";
            this.infopointSize.Size = new System.Drawing.Size(159, 20);
            this.infopointSize.TabIndex = 5;
            this.infopointSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GapLabel
            // 
            this.GapLabel.AutoSize = true;
            this.GapLabel.Location = new System.Drawing.Point(3, 61);
            this.GapLabel.Name = "GapLabel";
            this.GapLabel.Size = new System.Drawing.Size(27, 13);
            this.GapLabel.TabIndex = 4;
            this.GapLabel.Text = "Gap";
            // 
            // GapNumber
            // 
            this.GapNumber.Location = new System.Drawing.Point(6, 77);
            this.GapNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GapNumber.Name = "GapNumber";
            this.GapNumber.Size = new System.Drawing.Size(159, 20);
            this.GapNumber.TabIndex = 3;
            this.GapNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(7, 19);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(25, 13);
            this.KeyLabel.TabIndex = 2;
            this.KeyLabel.Text = "Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(7, 38);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(323, 20);
            this.KeyTextBox.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(697, 473);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(100, 25);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(595, 473);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 25);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(456, 473);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(133, 25);
            this.DecodeButton.TabIndex = 5;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 670);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CypherBox);
            this.Controls.Add(this.MessageGroup);
            this.Controls.Add(this.ImagePreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Form1";
            this.Text = "Steganexe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.MessageGroup.ResumeLayout(false);
            this.MessageGroup.PerformLayout();
            this.CypherBox.ResumeLayout(false);
            this.CypherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infopointSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GapNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePreview;
        private System.Windows.Forms.GroupBox MessageGroup;
        private System.Windows.Forms.GroupBox CypherBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label GapLabel;
        private System.Windows.Forms.NumericUpDown GapNumber;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.NumericUpDown infopointSize;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DecodeButton;
    }
}

