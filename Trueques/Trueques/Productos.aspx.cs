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
                Tengo();
                Busco();
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

        protected void Tengo()
        {
            try
            {
                var lista = (from a in db.Producto_T
                             where a.idUsuario == iduser
                             select a).ToList();
                grid_productos.DataSource = lista;
                grid_productos.DataBind();
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
            }
        }
        protected void Busco()
        {
            try
            {
                var lista = (from a in db.Producto_T
                             where a.idUsuario == iduser
                             select a).ToList();
                List<Producto_B> lista2 = new List<Producto_B>();

                for (int i = 1; i <= lista.Count; i++)
                {
                    List<Producto_B> product = (from a in db.Producto_B
                                     where a.idProductoT == lista[i].idProductoT
                                     select a).ToList();
                    for (int j = 1; j < product.Count; j++)
                    {
                        lista2.Add(product[j]);
                    }
                }
                grid_busco.DataSource = lista2;
                grid_busco.DataBind();
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
            }
        }
    }
}