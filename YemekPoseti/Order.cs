﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekPoşeti
{
	public class Order
	{
		public float SumPrice { get; set; }
		private float DiscountPercantage = 5;
		public float DiscountPrice { get; set; }
		public float FinalPrice;

		public List<ucBasket> FoodsInOrder = new List<ucBasket>();
		public List<int> foodIDList = new List<int>();
        public float MinOrderPrice { get; set; }

		public void GetSumPrice()
		{
			SumPrice = 0;
			foreach(ucBasket ucbasket in FoodsInOrder )
			{
				SumPrice += (ucbasket.QTY * ucbasket.Price);
			}
			DiscountPrice = Convert.ToSingle(Math.Round((SumPrice * DiscountPercantage)/100,2));
			FinalPrice = SumPrice - DiscountPrice;
		}
        
        public void PrintFoods(ListBox lbox)
        {
            lbox.Items.Clear();
            foreach(ucBasket food in FoodsInOrder)
            {
                if(food.QTY>0)
                    lbox.Items.Add(food.FoodName + " (" + food.QTY + " Adet)");
            }
        }
        
	}
}
