using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rattrapageCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment batiment = new Batiment("Immeuble NDONGO rue Valere ");

            Console.Out.WriteLine(batiment);

           Maison maison1 = new Maison("Rue Valere 1 , ", 8);

            Console.Out.WriteLine(maison1);

           Maison maison2 = new Maison();

            maison2.Adresse = "Rue Valere 2 , ";

            maison2.NbPiece = 5;

            Console.Out.WriteLine(maison2);

            Console.ReadKey();
        }
    }
}
