using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trueques.Entities;

namespace Trueques
{
    public partial class Panel_Usuario : System.Web.UI.Page
    {
        readonly TRKEntities db = new TRKEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                user.Text = Session["user"].ToString();
                string perfil = Session["user"].ToString();
                var query = (from a in db.Usuarios
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

        //protected void Button6_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("Modificacion.aspx");

        //}
    }
}