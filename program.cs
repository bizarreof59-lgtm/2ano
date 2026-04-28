#atividade classe3
-using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carlosatividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pesoa: ");
            Console.Write("nome: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da primeira pesoa: ");
            Console.Write("nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)

            {
                Console.WriteLine("Pessoa mais velha: " + p1.idade);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.idade);
            }


        }
    }
}


