using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precoUnitario, qtdFrota;

            Console.WriteLine("Digite a quantidade da frota");
            qtdFrota = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preco da unidade dos aviões");
            precoUnitario= Decimal.Parse(Console.ReadLine());

            Aplicativo6RN app6 = new Aplicativo6RN();
            Console.WriteLine(app6.CalculoGeral(precoUnitario,qtdFrota));
            Console.ReadKey();



        }
    }
}
