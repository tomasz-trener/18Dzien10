using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P06rzetwarzanieAsynchroniczneAJAX
{
    public partial class DefaultServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a= Convert.ToInt32(Request["liczba1"]);
            int b = Convert.ToInt32(Request["liczba2"]);

            string wynik = Convert.ToString(a + b);

            Response.Write(wynik);
        }
    }
}