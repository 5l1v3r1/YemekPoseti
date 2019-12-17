﻿namespace YemekPoşeti
{
	partial class LoginScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
			this.btnRegister = new MetroFramework.Controls.MetroButton();
			this.btnLogin = new MetroFramework.Controls.MetroButton();
			this.txtUserName = new MetroFramework.Controls.MetroTextBox();
			this.txtPass = new MetroFramework.Controls.MetroTextBox();
			this.pboxLogo = new System.Windows.Forms.PictureBox();
			this.lblForgetPass = new System.Windows.Forms.Label();
			this.lblErrorMsg = new System.Windows.Forms.Label();
			this.cboxRememberMe = new MetroFramework.Controls.MetroCheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.Violet;
			this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegister.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnRegister.Location = new System.Drawing.Point(56, 411);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(120, 45);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "Kayıt Ol!";
			this.btnRegister.UseCustomBackColor = true;
			this.btnRegister.UseSelectable = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.OldLace;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnLogin.Location = new System.Drawing.Point(186, 411);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(120, 45);
			this.btnLogin.Style = MetroFramework.MetroColorStyle.Purple;
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Giriş Yap!";
			this.btnLogin.UseCustomBackColor = true;
			this.btnLogin.UseSelectable = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtUserName
			// 
			// 
			// 
			// 
			this.txtUserName.CustomButton.Image = null;
			this.txtUserName.CustomButton.Location = new System.Drawing.Point(222, 2);
			this.txtUserName.CustomButton.Name = "";
			this.txtUserName.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUserName.CustomButton.TabIndex = 1;
			this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUserName.CustomButton.UseSelectable = true;
			this.txtUserName.CustomButton.Visible = false;
			this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtUserName.ForeColor = System.Drawing.Color.DarkGray;
			this.txtUserName.Lines = new string[] {
        "Kullanıcı adınız.."};
			this.txtUserName.Location = new System.Drawing.Point(56, 286);
			this.txtUserName.MaxLength = 32767;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.PasswordChar = '\0';
			this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUserName.SelectedText = "";
			this.txtUserName.SelectionLength = 0;
			this.txtUserName.SelectionStart = 0;
			this.txtUserName.ShortcutsEnabled = true;
			this.txtUserName.Size = new System.Drawing.Size(250, 30);
			this.txtUserName.TabIndex = 1;
			this.txtUserName.Text = "Kullanıcı adınız..";
			this.txtUserName.UseCustomBackColor = true;
			this.txtUserName.UseCustomForeColor = true;
			this.txtUserName.UseSelectable = true;
			this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
			// 
			// txtPass
			// 
			// 
			// 
			// 
			this.txtPass.CustomButton.Image = null;
			this.txtPass.CustomButton.Location = new System.Drawing.Point(222, 2);
			this.txtPass.CustomButton.Name = "";
			this.txtPass.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPass.CustomButton.TabIndex = 1;
			this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPass.CustomButton.UseSelectable = true;
			this.txtPass.CustomButton.Visible = false;
			this.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtPass.ForeColor = System.Drawing.Color.DarkGray;
			this.txtPass.Lines = new string[] {
        "Şifrenizi giriniz.."};
			this.txtPass.Location = new System.Drawing.Point(56, 338);
			this.txtPass.MaxLength = 32767;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '\0';
			this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPass.SelectedText = "";
			this.txtPass.SelectionLength = 0;
			this.txtPass.SelectionStart = 0;
			this.txtPass.ShortcutsEnabled = true;
			this.txtPass.Size = new System.Drawing.Size(250, 30);
			this.txtPass.TabIndex = 2;
			this.txtPass.Text = "Şifrenizi giriniz..";
			this.txtPass.UseCustomBackColor = true;
			this.txtPass.UseCustomForeColor = true;
			this.txtPass.UseSelectable = true;
			this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
			// 
			// pboxLogo
			// 
			this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
			this.pboxLogo.Location = new System.Drawing.Point(82, 69);
			this.pboxLogo.Name = "pboxLogo";
			this.pboxLogo.Size = new System.Drawing.Size(200, 200);
			this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxLogo.TabIndex = 2;
			this.pboxLogo.TabStop = false;
			// 
			// lblForgetPass
			// 
			this.lblForgetPass.AutoSize = true;
			this.lblForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblForgetPass.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblForgetPass.Location = new System.Drawing.Point(53, 371);
			this.lblForgetPass.Name = "lblForgetPass";
			this.lblForgetPass.Size = new System.Drawing.Size(97, 16);
			this.lblForgetPass.TabIndex = 5;
			this.lblForgetPass.Text = "Şifremi unuttum";
			// 
			// lblErrorMsg
			// 
			this.lblErrorMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblErrorMsg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
			this.lblErrorMsg.Location = new System.Drawing.Point(56, 470);
			this.lblErrorMsg.Name = "lblErrorMsg";
			this.lblErrorMsg.Size = new System.Drawing.Size(250, 25);
			this.lblErrorMsg.TabIndex = 6;
			this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cboxRememberMe
			// 
			this.cboxRememberMe.AutoSize = true;
			this.cboxRememberMe.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cboxRememberMe.Location = new System.Drawing.Point(222, 374);
			this.cboxRememberMe.Name = "cboxRememberMe";
			this.cboxRememberMe.Size = new System.Drawing.Size(84, 15);
			this.cboxRememberMe.TabIndex = 7;
			this.cboxRememberMe.Text = "Beni Hatırla";
			this.cboxRememberMe.UseSelectable = true;
			// 
			// LoginScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(365, 580);
			this.Controls.Add(this.cboxRememberMe);
			this.Controls.Add(this.lblErrorMsg);
			this.Controls.Add(this.lblForgetPass);
			this.Controls.Add(this.pboxLogo);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnRegister);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(365, 580);
			this.MinimumSize = new System.Drawing.Size(365, 580);
			this.Name = "LoginScreen";
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "YemekPoşeti";
			this.Load += new System.EventHandler(this.LoginScreen_Load);
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnRegister;
		private MetroFramework.Controls.MetroButton btnLogin;
		private MetroFramework.Controls.MetroTextBox txtUserName;
		private MetroFramework.Controls.MetroTextBox txtPass;
		private System.Windows.Forms.PictureBox pboxLogo;
		private System.Windows.Forms.Label lblForgetPass;
		private System.Windows.Forms.Label lblErrorMsg;
		private MetroFramework.Controls.MetroCheckBox cboxRememberMe;
	}
}

