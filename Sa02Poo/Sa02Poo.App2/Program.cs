using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoinicial, anoatual;

            anoinicial = int.Parse(Console.ReadLine());
            anoatual = int.Parse(Console.ReadLine());
            Aplicativo2RN app2 = new Aplicativo2RN();
            Console.WriteLine(app2.SubtraçãoDoisAnos(anoinicial, anoatual));
            Console.ReadKey();
    
        }
    }
}
