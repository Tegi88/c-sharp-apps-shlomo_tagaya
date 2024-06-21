using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shlomo_tagaya.Electric_Product
{
    public class ElectricProductMain
    {
        public static void ElectricProductMain4()
        {
            Console.WriteLine("new elctric");
            GameConsole e = new GameConsole();
            GameConsole e1 = new GameConsole("sony","console game",15,5500,"ps4");
            e.DisplayDetails();
            e1.DisplayDetails();
            e1.DisplayDetails1();
        }
        
    }
}
