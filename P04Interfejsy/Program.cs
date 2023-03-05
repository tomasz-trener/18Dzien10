using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KalkulatorGlowny k = new KalkulatorGlowny();
            double wynik1= k.Policz(3, 4, new KalkulatorDodajcy());
            double wynik2 = k.Policz(4, 7, new KalkulatorOdejmujacy());


        }
    }
}
