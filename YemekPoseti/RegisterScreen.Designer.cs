﻿namespace YemekPoşeti
{
	partial class RegisterScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
			this.btnRegister = new MetroFramework.Controls.MetroButton();
			this.txtUserName = new MetroFramework.Controls.MetroTextBox();
			this.pboxLogo = new System.Windows.Forms.PictureBox();
			this.txtPass = new MetroFramework.Controls.MetroTextBox();
			this.txtEmail = new MetroFramework.Controls.MetroTextBox();
			this.lblBack = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.Violet;
			this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegister.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnRegister.Location = new System.Drawing.Point(122, 304);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(120, 45);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "Kayıt Ol!";
			this.btnRegister.UseCustomBackColor = true;
			this.btnRegister.UseSelectable = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
			this.txtUserName.Location = new System.Drawing.Point(57, 127);
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
			this.txtUserName.UseCustomForeColor = true;
			this.txtUserName.UseSelectable = true;
			this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
			// 
			// pboxLogo
			// 
			this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
			this.pboxLogo.Location = new System.Drawing.Point(82, 410);
			this.pboxLogo.Name = "pboxLogo";
			this.pboxLogo.Size = new System.Drawing.Size(200, 87);
			this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pboxLogo.TabIndex = 2;
			this.pboxLogo.TabStop = false;
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
        "Şifre"};
			this.txtPass.Location = new System.Drawing.Point(57, 237);
			this.txtPass.MaxLength = 32767;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '\0';
			this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPass.SelectedText = "";
			this.txtPass.SelectionLength = 0;
			this.txtPass.SelectionStart = 0;
			this.txtPass.ShortcutsEnabled = true;
			this.txtPass.Size = new System.Drawing.Size(250, 30);
			this.txtPass.TabIndex = 3;
			this.txtPass.Text = "Şifre";
			this.txtPass.UseCustomForeColor = true;
			this.txtPass.UseSelectable = true;
			this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
			// 
			// txtEmail
			// 
			// 
			// 
			// 
			this.txtEmail.CustomButton.Image = null;
			this.txtEmail.CustomButton.Location = new System.Drawing.Point(222, 2);
			this.txtEmail.CustomButton.Name = "";
			this.txtEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtEmail.CustomButton.TabIndex = 1;
			this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtEmail.CustomButton.UseSelectable = true;
			this.txtEmail.CustomButton.Visible = false;
			this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
			this.txtEmail.Lines = new string[] {
        "E-Mail"};
			this.txtEmail.Location = new System.Drawing.Point(57, 182);
			this.txtEmail.MaxLength = 32767;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtEmail.SelectedText = "";
			this.txtEmail.SelectionLength = 0;
			this.txtEmail.SelectionStart = 0;
			this.txtEmail.ShortcutsEnabled = true;
			this.txtEmail.Size = new System.Drawing.Size(250, 30);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.Text = "E-Mail";
			this.txtEmail.UseCustomForeColor = true;
			this.txtEmail.UseSelectable = true;
			this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
			// 
			// lblBack
			// 
			this.lblBack.AutoSize = true;
			this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBack.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblBack.Location = new System.Drawing.Point(166, 352);
			this.lblBack.Name = "lblBack";
			this.lblBack.Size = new System.Drawing.Size(33, 16);
			this.lblBack.TabIndex = 4;
			this.lblBack.Text = "Geri";
			this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
			// 
			// RegisterScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(365, 580);
			this.Controls.Add(this.lblBack);
			this.Controls.Add(this.pboxLogo);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.btnRegister);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(365, 580);
			this.MinimumSize = new System.Drawing.Size(365, 580);
			this.Name = "RegisterScreen";
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "YemekPoşeti";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnRegister;
		private MetroFramework.Controls.MetroTextBox txtUserName;
		private System.Windows.Forms.PictureBox pboxLogo;
		private MetroFramework.Controls.MetroTextBox txtPass;
		private MetroFramework.Controls.MetroTextBox txtEmail;
		private System.Windows.Forms.Label lblBack;
	}
}

