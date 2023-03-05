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
    enum TrybOperacji
    {
        Nowy,
        Edycja
    }

    public partial class SzczegolyZawodnika : System.Web.UI.Page
    {
        public ZawodnikVM Wyswietlany;
        TrybOperacji trybOperacji;

        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            string idString = Request["id"];

            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.WczytajZawodnikow();
            List<string> kraje = mz.PodajKraje().ToList();
            kraje.Insert(0, "-- podaj kraj --");
            ddlKraj.DataSource = kraje;
            ddlKraj.DataBind();

            if (string.IsNullOrEmpty(idString)) // tryb tworzenia nowego zawodnika 
            {
                trybOperacji = TrybOperacji.Nowy;
                btnUsun.Visible = false;
            }
            else // tryb edycji 
            {
                trybOperacji = TrybOperacji.Edycja;
                int id = Convert.ToInt32(idString);

                //string connectionString =
                //"Data Source=.;Initial Catalog=Zawodnicy;User ID=sa;Password=alx";

                if (!Page.IsPostBack)
                {
                   
                   

                    Wyswietlany = mz.PodajZawodnika(id);

                    txtId.Text = Convert.ToString(Wyswietlany.Id_zawodnika);
                    txtImie.Text = Wyswietlany.Imie;
                    txtNazwisko.Text = Wyswietlany.Nazwisko;

                    //txtKraj.Text = Wyswietlany.Kraj;
                    
                    ddlKraj.Text = Wyswietlany.Kraj; // ustaw kontrolkę tak aby aktualnie wskazywała na kraj naszego zawodnika 
                    
                    txtDataUr.Text = Convert.ToString(Wyswietlany.DataUrodzenia);
                    txtWzrost.Text = Convert.ToString(Wyswietlany.Wzrost);
                    txtWaga.Text = Convert.ToString(Wyswietlany.Waga);
                }
            }

           
          


        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();

            ZawodnikVM zaowdnik = new ZawodnikVM();
         
            zaowdnik.Imie = txtImie.Text;
            zaowdnik.Nazwisko = txtNazwisko.Text;
            
          //  zaowdnik.Kraj = txtKraj.Text;
            zaowdnik.Kraj = ddlKraj.Text;

            zaowdnik.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);
            zaowdnik.Wzrost = Convert.ToInt32(txtWzrost.Text);
            zaowdnik.Waga = Convert.ToInt32(txtWaga.Text);

            if (trybOperacji == TrybOperacji.Nowy)
            {
                mz.Dodaj(zaowdnik);
            }
            else
            {
                zaowdnik.Id_zawodnika = Convert.ToInt32(txtId.Text);
                mz.Edytuj(zaowdnik);
            }
           

            Response.Redirect("Default.aspx");
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.Usun(id);
            Response.Redirect("Default.aspx");
        }
    }
}