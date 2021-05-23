namespace Lab04_1712534
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Location = new System.Drawing.Point(232, 63);
            this.textBoxUsername.MaximumSize = new System.Drawing.Size(310, 22);
            this.textBoxUsername.MinimumSize = new System.Drawing.Size(200, 22);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(293, 22);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(232, 126);
            this.textBoxPassword.MaximumSize = new System.Drawing.Size(310, 22);
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(200, 22);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(293, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(229, 33);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelUsername.Size = new System.Drawing.Size(110, 27);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Tên đăng nhập";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(229, 96);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelPassword.Size = new System.Drawing.Size(71, 27);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Mật khẩu";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Location = new System.Drawing.Point(404, 178);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Padding = new System.Windows.Forms.Padding(5);
            this.buttonLogin.Size = new System.Drawing.Size(121, 39);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 243);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.MaximumSize = new System.Drawing.Size(581, 290);
            this.MinimumSize = new System.Drawing.Size(581, 290);
            this.Name = "frmLogin";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

