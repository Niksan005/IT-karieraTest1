using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GoSkiing
{
    class Program
    {
        static void Main(string[] args)
        {
            



            double skiers = double.Parse(Console.ReadLine());
            double Jacets = double.Parse(Console.ReadLine());
            double kaski  = double.Parse(Console.ReadLine());
            double boots  = double.Parse(Console.ReadLine());

            Jacets *= 120;
            kaski *= 75;
            boots *= 299.90;

            double sum = Jacets + kaski + boots;
            sum *= skiers;
            sum += sum * 0.2;
            sum += 0.00001;
            Console.WriteLine("{0:0.00}", sum);

        }
    }
}
