using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Rectangle : Forme
    {

        private int longueur;
        private int largeur;
        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }
        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public Rectangle()
        {

        }
        public Rectangle(int Longueur, int Largeur)
        {
            this.Longueur = Longueur;
            this.Largeur = Largeur;
            


        }

        public override string ToString()
        {
            return "\nRectangle de longueur = " + Longueur + " et de largeur " + Largeur
                + "\nAire = " + Longueur * Largeur + "\nPérimetre = " + (Longueur * Largeur) / 2;
        }
    }
}
