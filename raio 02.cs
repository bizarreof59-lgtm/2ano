                            #ATIVIDADE RAIO 02
PROGRAM.CS:
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_raio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculadora calc = new Calculadora();
                Console.Write("Entre com o valor do raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double circ = calc.Circunferencia(raio);
                double  volume = calc.Volume(raio);
                Console.WriteLine("Circunferencia: " + circ.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor de PI: " + calc.pi.ToString("F2", CultureInfo.InvariantCulture));
          
}
    }
}
CALCULADORA:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_raio_02
{
    internal class Calculadora
    {
        public double pi = 3.14;
        
        public double Circunferencia (double r)
            { return 2.0 * r; }
        public double Volume (double r)
        { return 4.0 / 3.0 * pi * r * r * r; }
    }
}
