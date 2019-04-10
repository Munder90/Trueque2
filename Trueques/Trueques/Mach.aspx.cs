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
        int iduser;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string perfil = Session["user"].ToString();
                iduser = (from a in db.Usuarios
                          where a.Email == perfil
                          select a.idUsuario).FirstOrDefault();
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
        protected void Buscan()
        {
            try
            {
                var query = (from a in db.Producto_T
                             join b in db.Producto_B on a.idEtiqueta equals b.idEtiquetaB
                             where a.Disponible == true && b.Disponible == true && a.idUsuario == iduser
                             select new { a.nombreProductoT, a.imgProductoT, b.nombreProductoB, b.imgProductoB }).ToList();

                //var query (SELECT Producto_T.nombreProductoT, Producto_T.imgProductoT,
                //        Producto_B.nombreProductoB, Producto_B.imgProductoB
                //        FROM Producto_B, Producto_T
                //        WHERE Producto_T.idProductoT = Producto_B.idProductoB

                //        AND Producto_T.idEtiqueta = Producto_B.idEtiquetaB

                //        AND Producto_T.idUsuario = 1")
                GridView1.DataSource = query;
                GridView1.DataBind();
            }
            catch (Exception ex)
            { }
        }
    }
}