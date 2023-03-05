using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class KalkulatorOdejmujacy : IUmiejacyWykonywacOperacje
    {
        public double WykonajDzialanie(int a, int b)
        {
            return a - b;
        }
    }
}
