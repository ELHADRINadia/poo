using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_test
{
    class program
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            ren r1 = new ren();
            //lecture des infos
            Console.WriteLine("Donner le model");
                 c1.setModel(Console.ReadLine());
            Console.WriteLine("Donner Matricule");
            c1.setMatricule(Console.ReadLine());
            Console.WriteLine("Donner couleur de voiture");
            c1.setCouleur(Console.ReadLine());
            //Affichage
            Console.WriteLine(c1.AfficherInfos());
            Console.WriteLine("Afficher les infos de ren");
            Console.WriteLine("Donner nom");
            r1.setnom(Console.ReadLine());
            Console.WriteLine("Donner le model");
            r1.setModel(Console.ReadLine());
            Console.WriteLine("Donner Matricule");
            r1.setMatricule(Console.ReadLine());
            Console.WriteLine("Donner couleur de voiture");
            r1.setCouleur(Console.ReadLine());
            Console.WriteLine(r1.AfficherInfos());

            //  Console.WriteLine(c1.AfficherInfos());
            //pause
            Console.ReadLine();
            

        }

    }
}
