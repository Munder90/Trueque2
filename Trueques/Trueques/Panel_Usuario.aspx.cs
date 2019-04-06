using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trueques
{
    public partial class Panel_Usuario : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                user.Text = Session["user"].ToString();
                string perfil = Session["user"].ToString();
                var query = (from a in db.Usuario
                             where a.Email == perfil
                             select a).FirstOrDefault();

                panel_perfil.ImageUrl = query.Imagen_Perfil;
            }
            catch (Exception)
            {

                Response.Redirect("Login.aspx");
            }



        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificacion.aspx");

        }
    }
}