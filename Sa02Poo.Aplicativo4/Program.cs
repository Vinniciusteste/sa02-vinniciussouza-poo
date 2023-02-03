using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo4
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            decimal v1, v2;

            v1 = Decimal.Parse(Console.ReadLine());
            v2 = Decimal.Parse(Console.ReadLine());

            Aplicativo4RN app4 = new Aplicativo4RN();
            Console.WriteLine(app4.DividirDoisValores(v1, v2));
            Console.ReadKey();
        }
    }
}
