using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoMilitar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3-Desenvolva uma Aplicação console C# chamada ServicoMilitar que leia os dados de “6” pessoas 
             (nome, sexo, idade e altura). Se altura maior 1,80 
             e idade maior que 18, informar está apta ou não para cumprir o serviço militar obrigatório*/

            int x;
            for (x = 0; x <= 6; x++)
            {
                Console.WriteLine("-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine(">>>>>>>>>>>>>>  "+x+1 +"º CADASTRO  <<<<<<<<<<<<<<<<<");
                Console.WriteLine("-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Sexo: ");
                string sexo = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                if (idade >= 18)
                {
                    if (altura >= 1.8) { 
                        Console.WriteLine(nome+  " Esta apto(a) a servir o servico Militar"); 
                    }
                   
                }
                else
                {
                    Console.WriteLine(nome + " Não Esta apto(a) a servir o servico Militar");
                }
                
               
            }

            Console.ReadKey();
        }
    }
}
