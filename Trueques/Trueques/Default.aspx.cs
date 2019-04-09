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
                int cont = 1;
                for (int i = 0; i < 4; i++)
                {
                    for (int fil = 0; fil < 3; fil++)
                    {
                        byte[] img = new byte[0];
                        int numOfBytes = query[i].ToString().Length / 8;

                        for (int j = 0; j < numOfBytes; j++)
                        {
                            img[j] = Convert.ToByte(query[cont].ToString().Substring(8 * j, 8), 2);
                            cont++;
                        }
                        imagenes_b[i, fil] = ByteArrayToImage(img);
                    }
                }
                grid_buscan.DataSource = imagenes_b;
                grid_buscan.DataBind();
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
                int cont = 1;
                for (int i = 0; i < 4; i++)
                {
                    for (int fil = 0; fil < 3; fil++)
                    {
                        byte[] img = new byte[0];
                        int numOfBytes = query[i].ToString().Length / 8;

                        for (int j = 0; j < numOfBytes; j++)
                        {
                            img[j] = Convert.ToByte(query[cont].ToString().Substring(8 * i, 8), 2);
                            cont++;
                        }
                        imagenes_t[i, fil] = ByteArrayToImage(img);
                    }
                }
                grid_tienen.DataSource = imagenes_t;
                grid_tienen.DataBind();
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
            }
        }
    }
}