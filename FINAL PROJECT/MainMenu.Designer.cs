namespace FINAL_PROJECT
{
    partial class MainMenu
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
            this.btnstrt = new System.Windows.Forms.Button();
            this.btnhtp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstrt
            // 
            this.btnstrt.Location = new System.Drawing.Point(443, 252);
            this.btnstrt.Margin = new System.Windows.Forms.Padding(2);
            this.btnstrt.Name = "btnstrt";
            this.btnstrt.Size = new System.Drawing.Size(86, 19);
            this.btnstrt.TabIndex = 0;
            this.btnstrt.Text = "Start Game";
            this.btnstrt.UseVisualStyleBackColor = true;
            this.btnstrt.Click += new System.EventHandler(this.btnstrt_Click);
            // 
            // btnhtp
            // 
            this.btnhtp.Location = new System.Drawing.Point(443, 275);
            this.btnhtp.Margin = new System.Windows.Forms.Padding(2);
            this.btnhtp.Name = "btnhtp";
            this.btnhtp.Size = new System.Drawing.Size(86, 19);
            this.btnhtp.TabIndex = 1;
            this.btnhtp.Text = "How to Play";
            this.btnhtp.UseVisualStyleBackColor = true;
            this.btnhtp.Click += new System.EventHandler(this.btnhtp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FINAL_PROJECT.Properties.Resources._9e3923825ba4a4fa967858f980b8460f3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(172, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 235);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.d5ba59e608e6f1db1e0d5de47e30af79;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnhtp);
            this.Controls.Add(this.btnstrt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstrt;
        private System.Windows.Forms.Button btnhtp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

