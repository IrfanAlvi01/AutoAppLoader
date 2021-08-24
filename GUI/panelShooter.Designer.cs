namespace GUI
{
    partial class panelShooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelShooter));
            this.CloseButton = new System.Windows.Forms.Button();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCapture2 = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(22, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // buttonCapture
            // 
            this.buttonCapture.FlatAppearance.BorderSize = 0;
            this.buttonCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCapture.Image = ((System.Drawing.Image)(resources.GetObject("buttonCapture.Image")));
            this.buttonCapture.Location = new System.Drawing.Point(22, 67);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(57, 45);
            this.buttonCapture.TabIndex = 3;
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(130, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCapture2
            // 
            this.buttonCapture2.FlatAppearance.BorderSize = 0;
            this.buttonCapture2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCapture2.Image = ((System.Drawing.Image)(resources.GetObject("buttonCapture2.Image")));
            this.buttonCapture2.Location = new System.Drawing.Point(22, 123);
            this.buttonCapture2.Name = "buttonCapture2";
            this.buttonCapture2.Size = new System.Drawing.Size(57, 48);
            this.buttonCapture2.TabIndex = 5;
            this.buttonCapture2.UseVisualStyleBackColor = true;
            this.buttonCapture2.Click += new System.EventHandler(this.buttonCapture2_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.FlatAppearance.BorderSize = 0;
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonFolder.Image")));
            this.buttonFolder.Location = new System.Drawing.Point(48, 193);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(64, 57);
            this.buttonFolder.TabIndex = 6;
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // panelShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(511, 316);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.buttonCapture2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelShooter";
            this.Text = "panelShooter";
            this.Load += new System.EventHandler(this.panelShooter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCapture2;
        private System.Windows.Forms.Button buttonFolder;
    }
}