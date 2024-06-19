using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shlomo_tagaya.InventoryApp
{
    public class InventoryAppMain
    {
        public static void MainEntry()
        {
            ////Console.WriteLine("InventoryApp");
            //Product p1= new Product("Shampo",9,5,6);
            //Console.WriteLine(p1.ToString());
            TestInventory();
        }
        public static void TestInventory()
        {
            Console.WriteLine("Test Inventory");
            Product product1 = new Product("Phone",1, 200, 300);
            Inventory inventory1 = new Inventory(product1);
            Console.WriteLine("Should be Phone ... --> " + inventory1.GetProduct().GetProductName());
            inventory1.BuyProduct(1_000);
            Console.WriteLine("Should be 0... -->" + inventory1.GetAmount());
            Console.WriteLine("Should be 100,000... -->" + inventory1.GetBudget());
            inventory1.BuyProduct(400);
            Console.WriteLine("Should be 400... -->" + inventory1.GetAmount());
            Console.WriteLine("Should be 20,000... -->" + inventory1.GetBudget());
            inventory1.SellAll();
            Console.WriteLine("Should be 140,000... -->" + inventory1.GetBudget());
            Console.WriteLine("Should be True -->" + (inventory1.GetProduct()==null));
        }
    }
}
