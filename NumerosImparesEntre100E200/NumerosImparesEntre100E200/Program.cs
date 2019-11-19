using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImparesEntre100E200
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Desenvolva uma Aplicação console C# 
             * chamada NumerosImparesEntre100E200 que exiba os números ímpares entre 100 e 200.*/
            int x;
            for (x = 100; x <= 200; x++)
            {
                if (x % 2 != 0 )
                {
                    Console.WriteLine(x);
                }

            }

            Console.ReadKey();
        }
    }
}
