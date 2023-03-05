using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class KalkulatorGlowny
    {

        public double Policz(int a, int b , IUmiejacyWykonywacOperacje mechanizm )
        {
            return mechanizm.WykonajDzialanie(a, b);
        }
    }
}
