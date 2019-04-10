using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trueques.Entities;

namespace Trueques
{
    public partial class Producto : System.Web.UI.Page
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

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Productos.aspx");
        }

        protected void Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                int producto_t = 0;
                if (FileUpload1.HasFile)
                {
                    string[] dirs = Directory.GetFiles(Server.MapPath("~/Imagenes/Productos/"));
                    int cantidad = dirs.Length;
                    string ext = Path.GetExtension(FileUpload1.FileName);
                    string nombreArchivo = "img" + cantidad + ext;
                    string ruta = "~/Imagenes/Productos/" + nombreArchivo;
                    Producto_T proT = new Producto_T
                    {
                        nombreProductoT = Text_nombre_t.Text,
                        imgProductoT = ruta,
                        idUsuario = iduser,
                        idCategoria = 0,
                        idEtiqueta = 0,
                        Disponible = true
                    };
                    Categoria cat = db.Categorias.FirstOrDefault(x => x.nombreCat.Equals(Text_Categoria_t.Text));
                    if (cat == null)
                    {
                        Categoria cat_new = new Categoria
                        {
                            nombreCat = Text_Categoria_t.Text
                        };
                        db.Categorias.Add(cat_new);
                        db.SaveChanges();
                        cat = db.Categorias.FirstOrDefault(x => x.nombreCat.Equals(Text_Categoria_t.Text));
                    }
                    Etiqueta eti = db.Etiquetas.FirstOrDefault(x => x.descripcion.Equals(Text_Etiqueta_t.Text));
                    if (eti == null)
                    {
                        Etiqueta eti_new = new Etiqueta
                        {
                            descripcion = Text_Etiqueta_t.Text
                        };
                        db.Etiquetas.Add(eti_new);
                        db.SaveChanges();
                        eti = db.Etiquetas.FirstOrDefault(x => x.descripcion.Equals(Text_Etiqueta_t.Text));
                    }
                    proT.idCategoria = cat.idCategoria;
                    proT.idEtiqueta = eti.idEtiqueta;
                    db.Producto_T.Add(proT);
                    db.SaveChanges();
                    FileUpload1.SaveAs(Server.MapPath(ruta));
                    producto_t = (from x in db.Producto_T where x.nombreProductoT == Text_nombre_t.Text select x.idProductoT).FirstOrDefault();
                }
                if (FileUpload2.HasFile)
                {
                    string[] dirs = Directory.GetFiles(Server.MapPath("~/Imagenes/Productos/"));
                    int cantidad = dirs.Length;
                    string ext = Path.GetExtension(FileUpload1.FileName);
                    string nombreArchivo = "img" + cantidad + ext;
                    string ruta = "~/Imagenes/Productos/" + nombreArchivo;
                    Producto_B proB = new Producto_B
                    {
                        nombreProductoB = TextBox1.Text,
                        imgProductoB = ruta,
                        idUsuarioB = iduser,
                        idEtiquetaB = 0,
                        idProductoT = producto_t,
                        Disponible = true
                    };
                    Etiqueta eti = db.Etiquetas.FirstOrDefault(x => x.descripcion.Equals(TextBox2.Text));
                    if (eti == null)
                    {
                        Etiqueta eti_new = new Etiqueta
                        {
                            descripcion = TextBox2.Text
                        };
                        db.Etiquetas.Add(eti_new);
                        db.SaveChanges();
                        eti = db.Etiquetas.FirstOrDefault(x => x.descripcion.Equals(TextBox2.Text));
                    }
                    proB.idEtiquetaB = eti.idEtiqueta;
                    db.Producto_B.Add(proB);
                    db.SaveChanges();
                    FileUpload1.SaveAs(Server.MapPath(ruta));
                }
                if (FileUpload3.HasFile)
                {
                    string[] dirs = Directory.GetFiles(Server.MapPath("~/Imagenes/Productos/"));
                    int cantidad = dirs.Length;
                    string ext = Path.GetExtension(FileUpload1.FileName);
                    string nombreArchivo = "img" + cantidad + ext;
                    string ruta = "~/Imagenes/Productos/" + nombreArchivo;
                    Producto_B proB = new Producto_B
                    {
                        nombreProductoB = TextBox3.Text,
                        imgProductoB = ruta,
                        idUsuarioB = iduser,
                        idEtiquetaB = 0,
                        idProductoT = producto_t,
                        Disponible = true
                    };
                    Etiqueta eti = db.Etiquetas.FirstOrDefault(x => x.descripcion.Equals(TextBox4.Text));
                    if (eti == null)
                    {
                        Etiqueta eti_new = new Etiqueta
                        {
                            descripcion = TextBox4.Text
                        };
                        db.Etiquetas.Add(eti_new);
                        db.SaveChanges();
                        eti = db.Etiquetas.FirstOrDefault(x => x.descripcion.Equals(TextBox4.Text));
                    }
                    proB.idEtiquetaB = eti.idEtiqueta;
                    db.Producto_B.Add(proB);
                    db.SaveChanges();
                    FileUpload1.SaveAs(Server.MapPath(ruta));
                }
                if (FileUpload4.HasFile)
                {
                    string[] dirs = Directory.GetFiles(Server.MapPath("~/Imagenes/Productos/"));
                    int cantidad = dirs.Length;
                    string ext = Path.GetExtension(FileUpload1.FileName);
                    string nombreArchivo = "img" + cantidad + ext;
                    string ruta = "~/Imagenes/Productos/" + nombreArchivo;
                    Producto_B proB = new Producto_B
                    {
                        nombreProductoB = TextBox5.Text,
                        imgProductoB = ruta,
                        idUsuarioB = iduser,
                        idEtiquetaB = 0,
                        idProductoT = producto_t,
                        Disponible = true
                    };
                    Etiqueta eti = db.Etiquetas.FirstOrDefault(x => x.descripcion.Equals(TextBox6.Text));
                    if (eti == null)
                    {
                        Etiqueta eti_new = new Etiqueta
                        {
                            descripcion = TextBox6.Text
                        };
                        db.Etiquetas.Add(eti_new);
                        db.SaveChanges();
                        eti = db.Etiquetas.FirstOrDefault(x => x.descripcion.Equals(TextBox6.Text));
                    }
                    proB.idEtiquetaB = eti.idEtiqueta;
                    db.Producto_B.Add(proB);
                    db.SaveChanges();
                    FileUpload1.SaveAs(Server.MapPath(ruta));
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                Response.Redirect("Productos.aspx");
            }
        }
    }
}