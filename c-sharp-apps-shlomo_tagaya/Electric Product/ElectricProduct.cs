using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shlomo_tagaya.Electric_Product
{
    public class ElectricProduct
    {
        private string productName;
        private string productDescription;
        private double producWigth;
        private double producPrice;

        public ElectricProduct(string productName, string productDescription, double producWigth, double producPrice)
        {
            this.productName = productName;
            this.productDescription = productDescription;
            this.producWigth = producWigth;
            this.producPrice = producPrice;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name = {productName}, Description = {productDescription}, Wigth = {producWigth},Price={producPrice}");
        }
    }
}
