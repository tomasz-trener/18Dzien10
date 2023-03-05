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
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(3000);


            string filtr = Request["filtr"];

            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.WczytajZawodnikow();
            Zawodnicy = mz.PrzefiltrujZawodnikow(filtr);
           

        }
    }
}