using P01AplikacjaZawodnicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class DefaultServer : System.Web.UI.Page
    {
        public ZawodnikVM[] Zawodnicy;
        public int LiczbaStron;
        public int WybranaStrona;
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(3000);


            string filtr = Request["filtr"];

            int ile = Convert.ToInt32(Request["ilePokazac"]);
            int strona = Convert.ToInt32(Request["nrStrony"]);
            WybranaStrona = strona;

            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.WczytajZawodnikow();
            Zawodnicy = mz.PrzefiltrujZawodnikow(filtr,ile,strona);

            int ileRekordow = mz.TablicaZawodnikow.Length;

            double liczbaStron = Math.Ceiling(Convert.ToDouble(ileRekordow) / ile);
            LiczbaStron = Convert.ToInt32(liczbaStron);
        }
    }
}