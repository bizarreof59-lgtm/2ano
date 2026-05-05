
                                                           #ATIVIDADE RETANGULO
                                      -Retangulo.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace retaNGULO
{
    internal class RETANGULO
    {
        public double Largura;
        public double Altura;

        public double Area()
        { return Largura * Altura; }
        public double perimetro()
        { return 2*(Largura + Altura); }
        public double diagonal()
        { return Math.Sqrt(Largura * Largura + Altura * Altura); }
    }
}

                                      -Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace retaNGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
           RETANGULO ret = new RETANGULO();

            Console.WriteLine("");
            ret.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = "+ret.diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
 
