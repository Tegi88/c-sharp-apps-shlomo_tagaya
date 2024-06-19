using c_sharp_apps_shlomo_tagaya.BankApp;
using c_sharp_apps_shlomo_tagaya.DraftApp;
using c_sharp_apps_shlomo_tagaya.SportApp;
using c_sharp_apps_shlomo_tagaya.TransportationApp;
using c_sharp_apps_shlomo_tagaya.InventoryApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shlomo_tagaya.common
{
    public class ProcessManager
    {
        public static void RunMainProcess()
        {
            Console.WriteLine("Choos On Options:");
            Console.WriteLine("==================");
            Console.WriteLine("1 - Bank App");
            Console.WriteLine("2 - Sport App");
            Console.WriteLine("3 - Transportation App");
            Console.WriteLine("4 - Draft App");
            Console.WriteLine("5 - Inventory App");
            Console.WriteLine("0 - Exit");
            int choos = int.Parse(Console.ReadLine());
            while (choos > 0 )
            {
                switch (choos)
                {
                    case 1:
                        BankAppMain.MainEntry();
                        break;
                    case 2:
                        SportAppMain.MainEntry();
                        break;
                    case 3:
                        TransportationAppMain.MainEntry();
                        break;
                    case 4:
                        DraftAppMain.MainEntry();
                        break;
                    case 5:
                        InventoryAppMain.MainEntry();
                        break;

                    case 0:
                        Console.WriteLine("exit");
                        break;

                    default:
                        // code block
                        break;
                }
                 choos = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
