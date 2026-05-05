#atividade classe2
- using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carlosatividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("nome: ");
            f1.nome =Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario=double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("nome: ");
            f2.nome =Console.ReadLine();
            Console.WriteLine("Salario: ");
            f2.salario=double.Parse(Console.ReadLine());

            double salario_media = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("salario medio = " + salario_media);
        }
    }
}


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


