# Ola Pesooal , Me chamo Carlos Eduardo
# Bem vindo ao meu perfil do github
- Atualmente estou aprendendo sobre linguagem c# , banco de dados , figma etc...
- atualmente estamos aprendendo sobre metodos , classes e manipulaçao de dados.
- estou buscando aprender mais sobre programaçao.
- como entrar em contato comigo: bizarreof59@gmail.com

#atividade
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
#classe
-using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carlosatividades
{
    internal class Funcionario
    {
      public string nome;
      public double salario;
    }
}
