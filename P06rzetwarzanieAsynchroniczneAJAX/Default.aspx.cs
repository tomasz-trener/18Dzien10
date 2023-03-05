using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P06rzetwarzanieAsynchroniczneAJAX
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWynik_Click(object sender, EventArgs e)
        {
            lblWynik.Text =
                (Convert.ToInt32(txtLiczba1ASP.Text) +
                 Convert.ToInt32(txtLiczba2ASP.Text))
                .ToString();
        }
    }
}