using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    class Cercle : Forme

    {
        private int rayon;
        public int Rayon {
            get { return rayon; }
            set { rayon = value; }
        }
        public const double PI = 3.1415926535897931;
        
        public Cercle()
        {

        }
        public Cercle(int Rayon)
        {
            this.Rayon = Rayon;
           

        }
        public override string ToString()
        {
            return "\nCercle de rayon = " + Rayon + "\n Aire = " + 2 * PI * Rayon + "\nPérimetre = " + PI * (Rayon * Rayon);
        }

        
    }
}
