using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal v1, v2;
            v1 = Decimal.Parse(Console.ReadLine());
            v2 = Decimal.Parse(Console.ReadLine());

            Aplicativo1RN app1 = new Aplicativo1RN();
            Console.WriteLine(app1.SomarDoisAvioes(v1,v2));
            Console.ReadKey();


        }
    }
}
