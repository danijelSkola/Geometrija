using System;
using System.Collections.Generic;
using System.Text;

namespace Geometrija
{
    public class Duzina
    {
        private Tocka _a;
        private Tocka _b;
        public Duzina(Tocka A, Tocka B)
        {
            this._a = A;
            this._b = B;
        }

        public double Duljina()
        {
            return Math.Sqrt(Math.Pow(_b.X - _a.X, 2) + Math.Pow(_b.Y - _a.Y, 2));
        }
    }
}
