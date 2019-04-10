using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trueques.Entities;

namespace Trueques
{
    public partial class Productos : System.Web.UI.Page
    {
        readonly TRKEntities db = new TRKEntities();
        int iduser;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string modif_id = Session["user"].ToString();
                iduser = (from a in db.Usuarios
                          where a.Email == modif_id
                          select a.idUsuario).FirstOrDefault();
            }
            catch (Exception)
            {

                Response.Redirect("Login.aspx");
            }
        }

        protected void Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Nuevo.aspx");
        }
    }
}