
using System;

namespace TP1Exercice3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string rep;
            do
            {
                Console.WriteLine("Donner reference : ");
                string reff = Console.ReadLine();
                Console.WriteLine("Donner designation : ");
                string des = Console.ReadLine();
                Console.WriteLine("Donner prix : ");
                double prix = double.Parse(Console.ReadLine());
                Article a = new Article(reff, des, prix);
                a.AfficherArticle();
                Console.WriteLine( "Prix = " + a.CalculerPrixTTC());
                Console.WriteLine("Ajouter autre article : O pour oui N pour non ");
                rep = Console.ReadLine();
            } while (rep.Equals("O") );
        }

    }
}
