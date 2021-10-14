using System;
using System.Collections.Generic;
using System.Text;

namespace Geometrija
{
    public class Trokut : GeometrijskiLik
    {
        private Tocka _a;
        private Tocka _b;
        private Tocka _c;

        private Duzina _ab;
        private Duzina _bc;
        private Duzina _ca;
        public Trokut(Tocka A, Tocka B, Tocka C)
        {
            this._a = A;
            this._b = B;
            this._c = C;
            _ab = new Duzina(_a, _b);
            _bc = new Duzina(_b, _c);
            _ca = new Duzina(_c, _a);
            Console.WriteLine("Stvoren je trokut");
        }

        public double Opseg()
        {
            return _ab.Duljina() + _bc.Duljina() + _ca.Duljina();
        }

        public override double Opseg()
        {
            throw new NotImplementedException();
        }

        public override double Povrsina()
        {
            throw new NotImplementedException();
        }
    }
}
