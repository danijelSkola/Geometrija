using System;

namespace Geometrija
{
    class Program
    {
        static void Main(string[] args)
        {
            Tocka A = new Tocka(0, 0);
            Tocka B = new Tocka(0, 3);
            Trokut abc = new Trokut(A, B, new Tocka(4, 0));
            Console.WriteLine(abc.Opseg());
        }
    }
}
