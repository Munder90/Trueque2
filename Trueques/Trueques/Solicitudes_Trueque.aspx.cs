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
    public partial class Solicitudes_Trueque : System.Web.UI.Page
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
                Buscan();
                Tienen();
            }
            catch (Exception)
            {

                Response.Redirect("Login.aspx");
            }
        }

        public System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            MemoryStream img = new MemoryStream(byteArray);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(img);
            return returnImage;
        }

        public byte[] Pasar(System.Data.Linq.Binary binary)
        {
            int cont = 1;
            byte[] img = new byte[0];
            int numOfBytes = binary.ToString().Length / 8;

            for (int j = 0; j < numOfBytes; j++)
            {
                img[j] = Convert.ToByte(binary.ToString().Substring(8 * j, 8), 2);
                cont++;
            }
            return img;
             
        }

        protected void Buscan()
        {
            try
            {
                var query = (from a in db.Trueques
                             where a.idUsuarioT == iduser
                             select a).ToList();
                
                grid_buscan1.DataSource = ObjAList1(query);
                grid_buscan1.DataBind();
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
            }
        }

        public partial class DET_AGENTE1 : IEquatable<DET_AGENTE1>
        {
            public string ApodoUser { get; set; }
            public string ProductoBuscan { get; set; }
            public string ImagenBuscan { get; set; }
            public string EtiquetaBuscan { get; set; }
            public string ProductoTienes { get; set; }
            public string ImagenTienes { get; set; }
            public string EtiquetaTienes { get; set; }
            public string Estatus { get; set; }

            public bool Equals(DET_AGENTE1 other)
            {
                throw new NotImplementedException();
            }
        }

        private List<DET_AGENTE1> ObjAList1(List<Trueque> dt)
        {
            List<DET_AGENTE1> ld = new List<DET_AGENTE1>();

            var rowsc = dt.Count();
            var rows = 1;

            for (int i = rows; i < rowsc; i++)
            {
                DET_AGENTE1 doc = new DET_AGENTE1();
                var com = dt[i].idUsuarioB;
                if (!string.IsNullOrEmpty(com.ToString()))
                {
                    doc.ApodoUser = (from x in db.Usuarios where x.idUsuario == com select x.Apodo).FirstOrDefault();
                }
                com = dt[i].idProductoB;
                if (!string.IsNullOrEmpty(com.ToString()))
                {
                    Producto_B pro = db.Producto_B.FirstOrDefault(x => x.idProductoB.Equals(com));
                    doc.ProductoBuscan = pro.nombreProductoB;
                    doc.ImagenBuscan = /*ByteArrayToImage(Pasar(*/pro.imgProductoB/*))*/;
                    doc.EtiquetaBuscan = (from x in db.Etiquetas where x.idEtiqueta == Convert.ToInt32(pro.Etiqueta) select x.descripcion).FirstOrDefault();
                }
                com = dt[i].idProductoT;
                if (!string.IsNullOrEmpty(com.ToString()))
                {
                    Producto_T pro = db.Producto_T.FirstOrDefault(x => x.idProductoT.Equals(com));
                    doc.ProductoTienes = pro.nombreProductoT;
                    doc.ImagenTienes = /*ByteArrayToImage(Pasar(*/pro.imgProductoT/*))*/;
                    doc.EtiquetaTienes = (from x in db.Etiquetas where x.idEtiqueta == Convert.ToInt32(pro.Etiqueta) select x.descripcion).FirstOrDefault();
                }
                var com1 = dt[i].Estatus;
                if (string.IsNullOrEmpty(com1.ToString()))
                { doc.Estatus = "En espera"; }
                else if (com1 == true)
                { doc.Estatus = "Aceptado"; }
                else
                { doc.Estatus = "Rechazado"; }
                ld.Add(doc);
            }
            return ld;
        }

        protected void Tienen()
        {
            try
            {
                var query = (from a in db.Trueques
                             where a.idUsuarioB == iduser
                             select a).ToList();

                grid_tienen1.DataSource = ObjAList2(query);
                grid_tienen1.DataBind();
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
            }
        }

        public partial class DET_AGENTE2 : IEquatable<DET_AGENTE2>
        {
            public string ApodoUser { get; set; }
            public string ProductoBuscas { get; set; }
            public string ImagenBuscas { get; set; }
            public string EtiquetaBuscas { get; set; }
            public string ProductoTienen { get; set; }
            public string ImagenTienen { get; set; }
            public string EtiquetaTienen { get; set; }
            public string Estatus { get; set; }

            public bool Equals(DET_AGENTE2 other)
            {
                throw new NotImplementedException();
            }
        }

        private List<DET_AGENTE2> ObjAList2(List<Trueque> dt)
        {
            List<DET_AGENTE2> ld = new List<DET_AGENTE2>();

            var rowsc = dt.Count();
            var rows = 1;

            for (int i = rows; i < rowsc; i++)
            {
                DET_AGENTE2 doc = new DET_AGENTE2();
                var com = dt[i].idUsuarioB;
                if (!string.IsNullOrEmpty(com.ToString()))
                {
                    doc.ApodoUser = (from x in db.Usuarios where x.idUsuario == com select x.Apodo).FirstOrDefault();
                }
                com = dt[i].idProductoB;
                if (!string.IsNullOrEmpty(com.ToString()))
                {
                    Producto_B pro = db.Producto_B.FirstOrDefault(x => x.idProductoB.Equals(com));
                    doc.ProductoBuscas = pro.nombreProductoB;
                    doc.ImagenBuscas = /*ByteArrayToImage(Pasar(*/pro.imgProductoB/*))*/;
                    doc.EtiquetaBuscas = (from x in db.Etiquetas where x.idEtiqueta == Convert.ToInt32(pro.Etiqueta) select x.descripcion).FirstOrDefault();
                }
                com = dt[i].idProductoT;
                if (!string.IsNullOrEmpty(com.ToString()))
                {
                    Producto_T pro = db.Producto_T.FirstOrDefault(x => x.idProductoT.Equals(com));
                    doc.ProductoTienen = pro.nombreProductoT;
                    doc.ImagenTienen = /*ByteArrayToImage(Pasar(*/pro.imgProductoT/*))*/;
                    doc.EtiquetaTienen = (from x in db.Etiquetas where x.idEtiqueta == Convert.ToInt32(pro.Etiqueta) select x.descripcion).FirstOrDefault();
                }
                var com1 = dt[i].Estatus;
                if (string.IsNullOrEmpty(com1.ToString()))
                { doc.Estatus = "En espera"; }
                else if (com1 == true)
                { doc.Estatus = "Aceptado"; }
                else
                { doc.Estatus = "Rechazado"; }
                ld.Add(doc);
            }
            return ld;
        }
    }
}