
                                             #ATIVIDADE FUNCIONARIO

                -Funcionario.cs
               using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    internal class funcionario

    {
        public string NOME;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido ()
            { return SalarioBruto-Imposto; }
        public void AumentarSalario (double porcentagem)
        { SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100); }
        
        public override string ToString()
        {
            return NOME
            +",r$ "
            +SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
            
        }
    }
}
             -program.cs
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionario func = new funcionario();

            Console.Write("Nome: ");
            func.NOME = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto");
            func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Funcionario: " + func);
            Console.WriteLine("");
            Console.Write("Deseja aumentar o salario em qual porcentagem: ");
            double portcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            func.AumentarSalario(portcent);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + func);

        }
    }
} 

