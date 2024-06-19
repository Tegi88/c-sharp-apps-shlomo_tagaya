using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shlomo_tagaya.InventoryApp
{
    public class Product
    {
        private string productName;
        private int minAmount;
        private double costPrice;
        private double sellingPrice;

        public Product() { }
        public Product(string productName, int minAmount, double costPrice, double sellingPrice)
        {
            this.productName = productName;
            SetMinAmount( minAmount);
            this.costPrice = costPrice;
            this.sellingPrice = sellingPrice;
        }
        public void SetProductName(string productName)
        {
            this.productName = productName;
        }
        public string GetProductName()
        {
            return this.productName;
        }
        public void SetMinAmount(int minAmount) 
        {
            if(minAmount>=100)
              this.minAmount = minAmount;
            else
                Console.WriteLine("The Amount need to be Above 100 or equal");
        }

        public  int GetMinAmount()
        {
            return this.minAmount;
        }

        public void SetCostPrice(double costPrice) 
        {
            this.costPrice= costPrice;
        }
        public   double GetCostPrice()
        {
            return this.costPrice;
        }

        public void SetSellingPrice(double sellingPrice)
        {
            this.sellingPrice = sellingPrice;
        }
        public double GetSellingPrice() 
        { 
            return this.sellingPrice; 
        }

        public override string ToString()
        {
            return this.productName+" "+this.minAmount+" "+this.costPrice+" "+this.sellingPrice;
        }

        
    }
}
