using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trueques.Entities;

namespace Trueques
{
    public partial class Cambia_Password : System.Web.UI.Page
    {
        readonly TRKEntities db = new TRKEntities();
        //Pregunta email;
        public string confirmar, antiguo, nuevo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Restablecer_Click(object sender, EventArgs e)
        {
            string pass = con_pass_1.Text;
            Regex regex2 = new Regex("^(?=.*[a-z])(?=.*[!@#$%^&*()_+<>|./?,-])(?=.*[A-Z])(?=.*[^a-zA-Z]).{8,}$");
            Match match2 = regex2.Match(pass);
            if (match2.Success)
            {
                if (pass == con_pass_2.Text)
                {
                    string modif_pass = Session["user"].ToString();
                    var query = (from a in db.Usuarios
                                 where a.Email == modif_pass
                                 select a).FirstOrDefault();
                    query.Password = Seguridad.Encriptar(pass);
                    db.SaveChanges();
                    Session.Remove("user");
                    Response.Redirect("Login.aspx");

                }
                else
                {
                    nopass.Text = "Contraseñas no iguales";
                    nopass2.Text = "Contraseñas no iguales";
                }

            }
            else
            {
                nopass.Text = "Deben ser Minimo 8 caracteres, 1 Mayuscula, 1 Minuscula, 1 Numero, 1 Simbolo";
                nopass2.Text = "Deben ser Minimo 8 caracteres, 1 Mayuscula, 1 Minuscula, 1 Numero, 1 Simbolo";

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }
    }
}