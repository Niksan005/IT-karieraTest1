using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodHad = int.Parse(Console.ReadLine());
            double firstCatEat = double.Parse(Console.ReadLine());
            double secondCatEat = double.Parse(Console.ReadLine());


            double HasEaten = (firstCatEat + secondCatEat) * days;
            if(foodHad >= HasEaten)
            {
                Console.WriteLine("The cats are well fed.");
                Console.WriteLine("{0} kilos of food left", Math.Ceiling(foodHad- HasEaten));
            }
            else
            {
                Console.WriteLine("The cats are hungry.");
                Console.WriteLine("{0} more kilos of food are needed.", Math.Floor(HasEaten - foodHad));
                
            }

        }
    }
}
