using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кристаллы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int Price = 10;
            int crystalPrice;
            int totalCrystal;
            Console.Write("Сколько кристаллов вы хотите купить?");
            totalCrystal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cколько у вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());
            crystalPrice = gold - Price * totalCrystal; 
            Console.WriteLine(" У вас осталось золото " + crystalPrice + " У вас криссталов " + totalCrystal);
        }
    }
}
