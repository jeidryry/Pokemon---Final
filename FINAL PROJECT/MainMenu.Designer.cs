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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnstrt
            // 
            this.btnstrt.Location = new System.Drawing.Point(443, 202);
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
            this.btnhtp.Location = new System.Drawing.Point(443, 225);
            this.btnhtp.Margin = new System.Windows.Forms.Padding(2);
            this.btnhtp.Name = "btnhtp";
            this.btnhtp.Size = new System.Drawing.Size(86, 19);
            this.btnhtp.TabIndex = 1;
            this.btnhtp.Text = "How to Play";
            this.btnhtp.UseVisualStyleBackColor = true;
            this.btnhtp.Click += new System.EventHandler(this.btnhtp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 114);
            this.label1.TabIndex = 3;
            this.label1.Text = "POKEMON GAME";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FINAL_PROJECT.Properties.Resources.d5ba59e608e6f1db1e0d5de47e30af79;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhtp);
            this.Controls.Add(this.btnstrt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstrt;
        private System.Windows.Forms.Button btnhtp;
        private System.Windows.Forms.Label label1;
    }
}

