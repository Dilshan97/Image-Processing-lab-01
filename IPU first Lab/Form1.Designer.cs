namespace IPU_first_Lab
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
            this.convertedImage = new System.Windows.Forms.PictureBox();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.grayBtn = new System.Windows.Forms.Button();
            this.thresholdBtn = new System.Windows.Forms.Button();
            this.negetiveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.extractBtn = new System.Windows.Forms.Button();
            this.transformBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.convertedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // convertedImage
            // 
            this.convertedImage.Location = new System.Drawing.Point(520, 45);
            this.convertedImage.Name = "convertedImage";
            this.convertedImage.Size = new System.Drawing.Size(218, 203);
            this.convertedImage.TabIndex = 0;
            this.convertedImage.TabStop = false;
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(37, 45);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(218, 203);
            this.originalImage.TabIndex = 1;
            this.originalImage.TabStop = false;
            this.originalImage.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // grayBtn
            // 
            this.grayBtn.Location = new System.Drawing.Point(332, 32);
            this.grayBtn.Name = "grayBtn";
            this.grayBtn.Size = new System.Drawing.Size(126, 43);
            this.grayBtn.TabIndex = 2;
            this.grayBtn.Text = "Gray Scale >>";
            this.grayBtn.UseVisualStyleBackColor = true;
            this.grayBtn.Click += new System.EventHandler(this.grayBtn_Click);
            // 
            // thresholdBtn
            // 
            this.thresholdBtn.Location = new System.Drawing.Point(332, 84);
            this.thresholdBtn.Name = "thresholdBtn";
            this.thresholdBtn.Size = new System.Drawing.Size(126, 43);
            this.thresholdBtn.TabIndex = 3;
            this.thresholdBtn.Text = "Threshold >>";
            this.thresholdBtn.UseVisualStyleBackColor = true;
            this.thresholdBtn.Click += new System.EventHandler(this.thresholdBtn_Click);
            // 
            // negetiveBtn
            // 
            this.negetiveBtn.Location = new System.Drawing.Point(332, 137);
            this.negetiveBtn.Name = "negetiveBtn";
            this.negetiveBtn.Size = new System.Drawing.Size(126, 43);
            this.negetiveBtn.TabIndex = 4;
            this.negetiveBtn.Text = "Negetive >>";
            this.negetiveBtn.UseVisualStyleBackColor = true;
            this.negetiveBtn.Click += new System.EventHandler(this.negetiveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(76, 269);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(112, 41);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // extractBtn
            // 
            this.extractBtn.Location = new System.Drawing.Point(332, 192);
            this.extractBtn.Name = "extractBtn";
            this.extractBtn.Size = new System.Drawing.Size(126, 43);
            this.extractBtn.TabIndex = 6;
            this.extractBtn.Text = "Extract >>";
            this.extractBtn.UseVisualStyleBackColor = true;
            this.extractBtn.Click += new System.EventHandler(this.extractBtn_Click);
            // 
            // transformBtn
            // 
            this.transformBtn.Location = new System.Drawing.Point(332, 241);
            this.transformBtn.Name = "transformBtn";
            this.transformBtn.Size = new System.Drawing.Size(126, 39);
            this.transformBtn.TabIndex = 7;
            this.transformBtn.Text = "Transform >>";
            this.transformBtn.UseVisualStyleBackColor = true;
            this.transformBtn.Click += new System.EventHandler(this.transformBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.transformBtn);
            this.Controls.Add(this.extractBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.negetiveBtn);
            this.Controls.Add(this.thresholdBtn);
            this.Controls.Add(this.grayBtn);
            this.Controls.Add(this.originalImage);
            this.Controls.Add(this.convertedImage);
            this.Name = "Form1";
            this.Text = " Image Enhancement techniques";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.convertedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox convertedImage;
        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.Button grayBtn;
        private System.Windows.Forms.Button thresholdBtn;
        private System.Windows.Forms.Button negetiveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button extractBtn;
        private System.Windows.Forms.Button transformBtn;
    }
}

