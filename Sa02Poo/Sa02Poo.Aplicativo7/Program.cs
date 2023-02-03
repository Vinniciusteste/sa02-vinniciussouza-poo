using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Sa02Poo.Aplicativo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal p1, p2, p3 ,p4 , p5;
            Console.WriteLine("Qual o valor da peça 1?");
            p1 = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual a o calor da peça 2?");
            p2 = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da peça 3?");
            p3 = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da peça 4?");
            p4 = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da peça 5?");
            p5 = Decimal.Parse(Console.ReadLine());

            Aplicativo7RN app7 = new Aplicativo7RN();
            Console.WriteLine("Valor total das peças: R$");
            Console.WriteLine(app7.SomaTotalDePeças(p1, p2, p3, p4, p5));
            Console.ReadKey();

        }
    }
}
