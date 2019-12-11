﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekPoşeti
{
    public partial class MainScreen : MetroFramework.Forms.MetroForm
    {
		private User LoggedUser;

        public MainScreen(User user)
        {
			LoggedUser = user;
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = "HOŞGELDİN, " + LoggedUser.UserName.ToUpper() + "!";
			LoadProfileData();
		}

		private void LoadProfileData()
		{
			lblUsername.Text = LoggedUser.UserName.ToUpper();
			lblCity.Text = LoggedUser.Location;
			lblDate.Text = LoggedUser.RegisterDate.ToShortDateString();
		}
	}
}
