﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace YemekPoşeti
{
	public partial class ucRestList : UserControl
	{
        public int RestID { get; set; }
        public int LocationID { get; set; }
        public int OwnerID { get; set; }
        public float MinOrderPrice { get; set; }


		public ucRestList()
		{
			InitializeComponent();
		}


		private void ucRestList_Load(object sender, EventArgs e)
		{
            bgRestRating.FlatAppearance.BorderSize = 0;
        }

	}
}
