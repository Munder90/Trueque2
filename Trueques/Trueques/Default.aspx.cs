using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trueques.Entities;

namespace Trueques
{
    public partial class _Default : Page
    {
        readonly TRKEntities db = new TRKEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Buscan();
            Tienen();
        }
        public System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            MemoryStream img = new MemoryStream(byteArray);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(img);
            return returnImage;
        }
        protected void Buscan()
        {
            try
            {
                var query = (from a in db.Producto_B
                             orderby a.idProductoB descending
                             select a.imgProductoB).ToArray();
                Array buscan = new Array[4, 3];
                System.Drawing.Image[,] imagenes_b = new System.Drawing.Image[4, 3];
                string[,] rutas = new string[4, 3];
                int cont = 0;
                //for (int i = 0; i < 4; i++)
                //{
                //    for (int fil = 0; fil < 3; fil++)
                //    {
                //        byte[] img = new byte[0];
                //        int numOfBytes = query[i].ToString().Length / 8;

                //        for (int j = 0; j < numOfBytes; j++)
                //        {
                //            img[j] = Convert.ToByte(query[cont].ToString().Substring(8 * j, 8), 2);
                //            cont++;
                //        }
                //        imagenes_b[i, fil] = ByteArrayToImage(img);
                //    }
                //}
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; i++)
                    {
                        rutas[i, j] = query[cont];
                        cont++;
                        if (cont >= query.Length)
                        {
                            break;
                        }
                    }
                    if (cont >= query.Length)
                    {
                        break;
                    }
                }
                Image1.ImageUrl = rutas[0, 0];
                Image2.ImageUrl = rutas[0, 1];
                Image3.ImageUrl = rutas[0, 2];
                Image4.ImageUrl = rutas[1, 0];
                Image5.ImageUrl = rutas[1, 1];
                Image6.ImageUrl = rutas[1, 2];
                Image7.ImageUrl = rutas[2, 0];
                Image8.ImageUrl = rutas[2, 1];
                Image9.ImageUrl = rutas[2, 2];
                Image10.ImageUrl = rutas[3, 0];
                Image11.ImageUrl = rutas[3, 1];
                Image12.ImageUrl = rutas[3, 2];
                //DirectoryInfo dirInfo = new DirectoryInfo(Server.MapPath("~/Imagenes/Productos"));
                //FileInfo[] fileInfo = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

                //GridView1.DataSource = fileInfo;
                //GridView1.DataBind();

                //grid_buscan.DataSource = imagenes_b;
                //grid_buscan.DataBind();
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
            }
        }
        protected void Tienen()
        {
            try
            {
                var query = (from a in db.Producto_T
                             orderby a.idProductoT descending
                             select a.imgProductoT).ToArray();
                Array buscan = new Array[4, 3];
                System.Drawing.Image[,] imagenes_t = new System.Drawing.Image[4, 3];
                string[,] rutas = new string[4, 3];
                int cont = 0;
                //for (int i = 0; i < 4; i++)
                //{
                //    for (int fil = 0; fil < 3; fil++)
                //    {
                //        byte[] img = new byte[0];
                //        int numOfBytes = query[i].ToString().Length / 8;

                //        for (int j = 0; j < numOfBytes; j++)
                //        {
                //            img[j] = Convert.ToByte(query[cont].ToString().Substring(8 * i, 8), 2);
                //            cont++;
                //        }
                //        imagenes_t[i, fil] = ByteArrayToImage(img);
                //    }
                //}
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; i++)
                    {
                        rutas[i, j] = query[cont];
                        cont++;
                        if (cont >= query.Length)
                        {
                            break;
                        }
                    }
                    if (cont >= query.Length)
                    {
                        break;
                    }
                }
                Image13.ImageUrl = rutas[0, 0];
                Image14.ImageUrl = rutas[0, 1];
                Image15.ImageUrl = rutas[0, 2];
                Image16.ImageUrl = rutas[1, 0];
                Image17.ImageUrl = rutas[1, 1];
                Image18.ImageUrl = rutas[1, 2];
                Image19.ImageUrl = rutas[2, 0];
                Image20.ImageUrl = rutas[2, 1];
                Image21.ImageUrl = rutas[2, 2];
                Image22.ImageUrl = rutas[3, 0];
                Image23.ImageUrl = rutas[3, 1];
                Image24.ImageUrl = rutas[3, 2];
                //grid_tienen.ResolveUrl(rutas[0, 0]);
                //var query2 = (from a in db.Producto_T
                //              orderby a.idProductoT descending
                //              select a).ToList();
                //grid_tienen.DataSource = query2;
                //grid_tienen.DataBind();
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
            }
        }
    }
}