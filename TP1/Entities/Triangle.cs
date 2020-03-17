using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    class Triangle : Forme
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int C
        {
            get { return c; }
            set { c = value; }
        }
       
        public Triangle()
        {

        }

        public Triangle(int A, int B, int C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            

        }
        public override string ToString()
        {
            return "\nTriangle de côté  A= " + A + " B= " + B + "C= " + C 
                + "\nAire = je sais pas " + "\nPérimetre = " + (A + B + C);
        }
    }
}
