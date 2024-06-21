using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shlomo_tagaya.Electric_Product
{
    public class GameConsole : ElectricProduct
    {
        private string consoleName;

        public GameConsole() : base("PC", "Brand:Asus", 20, 3599)
        {

        }

        public GameConsole(string productName, string productDescription, double producWigth, double producPrice, string consoleName) :
            base(productName, productDescription, producWigth, producPrice)
            {
            this.consoleName = consoleName;
            }

        public  void DisplayDetails1()
        {
            DisplayDetails();
            Console.Write($"{ consoleName }");
        }

    }
    
}
