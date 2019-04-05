using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trueques
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = this.usuario.Text;
            string password = this.password.Text;
            var consulta = from m in db.Usuario
                           select new
                           {
                               m.idUsuario,
                               m.Nombre,
                               m.Email,
                               m.Apodo,
                               m.Password,
                               m.Ciudad,
                               m.Telefono,
                               m.Nombre_Mascota
                           };
            foreach (var x in consulta)
            {
                if (x.Email == usuario && x.Password == password)
                {
                    Session["user"] = x.Email;
                    Response.Redirect("Panel_Usuario.aspx");
                }
                else
                {
                    error.Text = "Usuario y/o Contraseña Incorrectos";
                }
            }
        }

        protected void registrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void Recuperar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pregunta.aspx");
        }
    }
}