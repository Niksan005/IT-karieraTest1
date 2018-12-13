using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();

            double price = 0;
            if(days < 10)
            {
                if(room == "apartment")
                {
                    price = days * 70.00;
                    price -= price * 0.3;
                }
                else
                {
                    price = days * 125.00;
                    price -= price * 0.1;
                }
            }else if(days >= 10 && days <= 15)
            {
                if (room == "apartment")
                {
                    price = days * 70.00;
                    price -= price * 0.35;
                }
                else
                {
                    price = days * 125.00;
                    price -= price * 0.15;
                }
            }
            else if(days > 15)
            {
                if (room == "apartment")
                {
                    price = days * 70.00;
                    price -= price * 0.5;
                }
                else
                {
                    price = days * 125.00;
                    price -= price * 0.2;
                }
            }
            Console.WriteLine("{0:0.00}", price);
        }
    }
}
