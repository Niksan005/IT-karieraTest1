using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TakingCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int FoodHad = int.Parse(Console.ReadLine()) * 1000;
            int Ndays = int.Parse(Console.ReadLine());
            for(int i = 0; i < Ndays; i++)
            {
                FoodHad -= int.Parse(Console.ReadLine());

            }
            if(FoodHad >= 0)
            {
                Console.WriteLine("Food is enough! Leftovers: {0} grams.", FoodHad);
            }
            else
            {
                Console.WriteLine("Food is not enough. You need {0} grams more.", Math.Abs(FoodHad));
            }
        }
    }
}
