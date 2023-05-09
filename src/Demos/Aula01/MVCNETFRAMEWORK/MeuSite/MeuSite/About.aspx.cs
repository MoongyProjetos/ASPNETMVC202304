using MeuSite.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuSite
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Ctrl+ . .
            var classe = new Class1();
            var meuNome = classe.MeuMetodo(txtNome.Text);

            lblNome.Text = meuNome.ToUpper();
        }
    }
}