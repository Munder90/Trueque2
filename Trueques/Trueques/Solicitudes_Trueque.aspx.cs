using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trueques
{
    public partial class Solicitudes_Trueque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            try
            {
                string modif_id = Session["user"].ToString();
                var query = (from a in db.Usuario
                             where a.Email == modif_id
                             select a).FirstOrDefault();
            }
            catch (Exception)
            {

                Response.Redirect("Login.aspx");
            }
        }
    }
}