                            #ATIVIDADE
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;//adicionar essa biblioteca

namespace exercicio_raio
{
  
    internal class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");

            double raio = double .Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double Volume = volume (raio);

            Console.WriteLine("Circunferencia: "+ circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+ Volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: "+ pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        //Novo metodo de calculo de circunferencia
        static double Circunferencia (double r)
            { return 2.0 * pi * r; }
        static double volume (double r)
        { return 4.0 / 3.0 * pi * r * r * r; }
    }
}
