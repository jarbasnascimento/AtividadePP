using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeropar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.	Desenvolva uma Aplicação console C# chamada numeropar que exiba os números 
              de 1 a 50  na tela em ordem decrescente.*/

            int x;
            for (x = 50; x >=1; x--)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
             
            }

            Console.ReadKey();
        }
    }
}
