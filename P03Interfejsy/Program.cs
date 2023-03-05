using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IUmiejacyJezdzic> obiektyUmiejaceJezdzic = new List<IUmiejacyJezdzic>();

            obiektyUmiejaceJezdzic.Add(new Samochod());
            obiektyUmiejaceJezdzic.Add(new Amfibia());


            foreach (var u in obiektyUmiejaceJezdzic)
            {
                u.Jedz();
            }





        }
    }
}
