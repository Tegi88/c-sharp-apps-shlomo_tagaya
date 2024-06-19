using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shlomo_tagaya.InventoryApp
{
    public class Inventory
    {
        private Product product;
        private int amount;
        private double budget;

        public Inventory() { }
        public Inventory(Product product)
        {
            this.product = product;
            this.amount = 0;
            this.budget = 100000;
        }
        public Product GetProduct()
        {
            return this.product;
        }
        public void SetProduct(Product product)
        {
            this.product = product;
        }
        public int GetAmount()
        {
            return this.amount;
        }
        
        public  double GetBudget() 
        { 
            return this.budget; 
        }
        public  void SetBudget(double budget)
        {
            this.budget = budget;
        }

        public void BuyProduct(int quantity)
        {
            if (quantity < product.GetMinAmount())
            {
                Console.WriteLine($"Cannot purchase. The minimum purchase amount is {product.GetMinAmount()}.");
                return;
            }

            double totalCost = product.GetCostPrice() * quantity;

            if (totalCost > budget)
            {
                Console.WriteLine("Cannot purchase. Insufficient budget.");
                return;
            }

            amount += quantity;
            budget -= totalCost;
            Console.WriteLine($"Purchased {quantity} units of {product.GetProductName()}. New amount: {amount}, Remaining budget: {budget}");
        }

        public void SellAll()
        {
            if (product == null || amount == 0)
            {
                Console.WriteLine("No products to sell.");
                return;
            }

            double totalSaleValue = product.GetSellingPrice() * amount;
            budget += totalSaleValue;

            Console.WriteLine($"Sold all {amount} units of {product.GetProductName()} for {totalSaleValue}. Updated budget: {budget}");

            product = null;
            amount = 0;
        }


    }
}
