using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.UniqueCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int beg = b;
            if (a >= b) b = a + 1;

            for (; a <= 122;a++)
            {
                for (; b <= 122; b++)
                {
                    if (a != b)
                    {
                        for (int i = 1; i < 9; i++)
                        {

                            for (int j = 1; j < 9; j++)
                            {
                                if (i + j == 9)
                                {
                                    Console.Write((char)a + "" + (char)b + "" + i + "" + j + " ");
                                    break;
                                }
                            }
                        }
                    }
                }
                b = beg;
                if (a >= b) b = a + 1;
            }
            Console.WriteLine();
        }
    }
}
