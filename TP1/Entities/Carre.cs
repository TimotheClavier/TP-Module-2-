using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    class Carre : Forme
    {
        private int longueur;
        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }
        public Carre()
        {

        }
        public Carre( int Longueur)
        {
            this.Longueur = Longueur;
       
        }

        public override string ToString()
        {
            return "\nCarré de côté = " + Longueur + "\nAire = " + Longueur * Longueur
                + "\nPérimetre = " + (Longueur * 4);
        }
    }
}
