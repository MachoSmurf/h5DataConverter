namespace h5dataToGIF
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
            this.btnFindRawData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindPalette = new System.Windows.Forms.Button();
            this.tbRawLocation = new System.Windows.Forms.TextBox();
            this.tbPaletteLocation = new System.Windows.Forms.TextBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindRawData
            // 
            this.btnFindRawData.Location = new System.Drawing.Point(493, 19);
            this.btnFindRawData.Name = "btnFindRawData";
            this.btnFindRawData.Size = new System.Drawing.Size(75, 23);
            this.btnFindRawData.TabIndex = 0;
            this.btnFindRawData.Text = "Find";
            this.btnFindRawData.UseVisualStyleBackColor = true;
            this.btnFindRawData.Click += new System.EventHandler(this.btnFindRawData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raw Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palette Location:";
            // 
            // btnFindPalette
            // 
            this.btnFindPalette.Location = new System.Drawing.Point(493, 55);
            this.btnFindPalette.Name = "btnFindPalette";
            this.btnFindPalette.Size = new System.Drawing.Size(75, 23);
            this.btnFindPalette.TabIndex = 3;
            this.btnFindPalette.Text = "Find";
            this.btnFindPalette.UseVisualStyleBackColor = true;
            this.btnFindPalette.Click += new System.EventHandler(this.btnFindPalette_Click);
            // 
            // tbRawLocation
            // 
            this.tbRawLocation.Location = new System.Drawing.Point(136, 19);
            this.tbRawLocation.Name = "tbRawLocation";
            this.tbRawLocation.Size = new System.Drawing.Size(351, 22);
            this.tbRawLocation.TabIndex = 4;
            // 
            // tbPaletteLocation
            // 
            this.tbPaletteLocation.Location = new System.Drawing.Point(136, 55);
            this.tbPaletteLocation.Name = "tbPaletteLocation";
            this.tbPaletteLocation.Size = new System.Drawing.Size(351, 22);
            this.tbPaletteLocation.TabIndex = 5;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(414, 191);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(154, 23);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "Convert";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "JPG";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "GIF";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(15, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 77);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 226);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.tbPaletteLocation);
            this.Controls.Add(this.tbRawLocation);
            this.Controls.Add(this.btnFindPalette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindRawData);
            this.Name = "Form1";
            this.Text = "RawToGif";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindRawData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindPalette;
        private System.Windows.Forms.TextBox tbRawLocation;
        private System.Windows.Forms.TextBox tbPaletteLocation;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

