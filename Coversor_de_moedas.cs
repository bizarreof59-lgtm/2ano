                                                  ATIVIDADE
                                              COVERSOR DE MOEDAS

1- Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace convensorDeMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine());

            double result = conversordemoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
2- coversordemoedas.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace convensorDeMoeda
{
    internal class conversordemoeda
    {
        public static double Iof = 0.06;
        public static double DolarParaReal(double quantia, double cotacao)
        {
        double total = quantia * cotacao;

        return total + total* Iof;

       }

    }
}
