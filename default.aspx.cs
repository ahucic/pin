using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIN_projekt
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PopulateList();
            }
        }
        protected void ListBoxes_OnSelectedItemsChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBoxes.Items.Count; i++)

            {
                if (ListBoxes.Items[i].Selected)
                {
                    listaSQLDataContext db = new listaSQLDataContext();

                    lista_tablica SelectedItem = db.lista_tablicas.Where(p =>
                    p.listaID == Convert.ToInt32(ListBoxes.Items[i].Value)).FirstOrDefault();

                    db.lista_tablicas.DeleteOnSubmit(SelectedItem);
                    db.SubmitChanges();
                    PopulateList();
                }
            }
        }
        protected void CreateLista_OnClick(object sender, EventArgs e)
        {
            listaSQLDataContext db = new listaSQLDataContext();

            lista_tablica CurrentToDo = new lista_tablica
            {
                
                opis = ListaOpis.Text

            };

            db.lista_tablicas.InsertOnSubmit(CurrentToDo);
            db.SubmitChanges();
            PopulateList();

         
        }

        private void PopulateList()
        {
            listaSQLDataContext db = new listaSQLDataContext();

            ListBoxes.DataSource = db.lista_tablicas;
            ListBoxes.DataValueField = "listaID";
            ListBoxes.DataTextField = "opis";

            ListBoxes.DataBind();
        }
    }
}