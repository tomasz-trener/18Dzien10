using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Pytania
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a = "3";
            int b = Convert.ToInt32(a);

            int c = int.Parse(a);

            int e;
            bool czySieUdalo= int.TryParse(a,out e);

        }
    }
}
