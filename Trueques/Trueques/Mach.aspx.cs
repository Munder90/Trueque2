using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trueques.Entities;

namespace Trueques
{
    public partial class Mach : System.Web.UI.Page
    {
        readonly TRKEntities db = new TRKEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string perfil = Session["user"].ToString();
                var query = (from a in db.Usuarios
                             where a.Email == perfil
                             select a).FirstOrDefault();
            }
            catch (Exception)
            {

                Response.Redirect("Login.aspx");
            }
        }
        SqlConnection con = new SqlConnection
        ("Server = SF-0011; Initial Catalog = TRK; " +
            "Persist Security Info = True; User ID = sa; Password = daniel123");

        public void conexion()
        {
            con.Open();


        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }
        void ContactsGridView_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Mach")
            {

            }
        }
    }
}