using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TP1Exercice3
{
    internal class Article
    {
        private string refrence;
        private string designation;
        private double prixHT;
        static double tauxTVA = 0.19;
        

        public Article()
        {
        }
        public Article(string refrence, string designation, double prixHT)
        {
            this.refrence = refrence;
            this.designation = designation;
            this.prixHT = prixHT;
        }
        public Article(string reference, string designation)
        {
            this.designation = designation;
            this.refrence = reference;
        }

        Article a;
        public Article(Article a)
        {
             this.a= a;
        }
        public double CalculerPrixTTC()
        {
            return prixHT + (prixHT * tauxTVA / 100);
        }
        public void AfficherArticle()
        {
            Console.WriteLine("reference : "+this.refrence+" designation : "+this.designation+" prixHT : "+this.prixHT
                +" TVA "+tauxTVA);
        }
    }
}
