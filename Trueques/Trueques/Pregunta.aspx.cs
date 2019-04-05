using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trueques
{
    public partial class Pregunta : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string recuperarpass;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void recuperar_Click(object sender, EventArgs e)
        {
            string recuperar = email_recuperar.Text;


            var consulta = from m in db.Usuario
                           where m.Email == recuperar
                           select m;

            foreach (var x in consulta)
            {
                if (x.Email == recuperar && x.Nombre_Mascota == mascota_recuperar.Text)
                {
                    recumensaje.Text = "Su Password es: " + x.Password;
                }
                else
                {
                    recumensaje.Text = "Email y/o respuesta incorrectos";
                }
            }


        }

        protected void login_rec_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}