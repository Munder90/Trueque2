﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trueques.Entities;

namespace Trueques
{
    public partial class Modificacion : System.Web.UI.Page
    {
        readonly TRKEntities db = new TRKEntities();
        public string confirmar, antiguo, nuevo, ruta_old;
        public int bandera;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string modif_id = Session["user"].ToString();
                var query = (from a in db.Usuarios
                             where a.Email == modif_id
                             select a).FirstOrDefault();

                mod_nombre.Text = query.Nombre;
                mod_apodo.Text = query.Apodo;
                mod_ciudad.Text = query.Ciudad;
                mod_telefono.Text = query.Telefono;
                mod_email.Text = query.Email;
                test.Text = Seguridad.DesEncriptar(query.Password);
                //mod_password.Text = query.Password;
                modfecha.Text = query.Fecha_Nacimiento;
                mod_perfil.ImageUrl = query.Imagen_Perfil;
                ruta_old = mod_perfil.ImageUrl;


                //test.Text = query.Password;
            }
            catch (Exception)
            {

                Response.Redirect("Login.aspx");
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Panel_Usuario.aspx");
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {

            confirmar = mod_confpassword.Text;
            Regex regex2 = new Regex("^(?=.*[a-z])(?=.*[!@#$%^&*()_+<>|./?,-])(?=.*[A-Z])(?=.*[^a-zA-Z]).{8,}$");
            Match match2 = regex2.Match(mod_password.Text);
            if (match2.Success)
            {
                if (mod_password.Text == confirmar)
                {
                    string modif_id = Session["user"].ToString();
                    var query = (from a in db.Usuarios
                                 where a.Email == modif_id
                                 select a).FirstOrDefault();

                    query.Nombre = mod_nombre.Text;
                    query.Apodo = mod_apodo.Text;
                    query.Ciudad = mod_ciudad.Text;
                    query.Telefono = mod_telefono.Text;
                    query.Password = Seguridad.Encriptar(mod_password.Text);
                    //query.Imagen_Perfil = ruta;
                    if (FileUpload1.HasFile)
                    {
                        //si hay una archivo.
                        string nombreArchivo = FileUpload1.FileName;
                        string ruta = "~/Imagenes/Perfil/" + nombreArchivo;
                        FileUpload1.SaveAs(Server.MapPath(ruta));
                        query.Imagen_Perfil = ruta;

                        if (test.Text == confirmar)
                        {
                            //mod_password.Text = Seguridad.Encriptar(mod_password.Text);
                            // query.Password = mod_password.Text;
                            db.SaveChanges();
                            //File.SetAttributes(ruta_old, FileAttributes.Normal);
                            //File.Delete(ruta_old);
                            Response.Redirect("Panel_Usuario.aspx");

                        }
                        else
                        {

                            db.SaveChanges();
                            Session.Remove("user");
                            Response.Redirect("Login.aspx");
                        }
                    }
                    else
                    {
                        if (test.Text == confirmar)
                        {
                            db.SaveChanges();
                            Response.Redirect("Panel_Usuario.aspx");
                        }
                        else
                        {
                            db.SaveChanges();
                            Session.Remove("user");
                            Response.Redirect("Login.aspx");
                        }
                    }




                }
                else
                {
                    mod_nopass.Text = "Contraseñas no iguales";
                    mod_nopass2.Text = "Contraseñas no iguales";
                }

            }
            else
            {
                mod_nopass.Text = "Deben ser Minimo 8 caracteres, 1 Mayuscula, 1 Minuscula, 1 Numero, 1 Simbolo";
                mod_nopass2.Text = "Deben ser Minimo 8 caracteres, 1 Mayuscula, 1 Minuscula, 1 Numero, 1 Simbolo";
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string modif_id = Session["user"].ToString();
            var query = (from a in db.Usuarios
                         where a.Email == modif_id
                         select a).FirstOrDefault();

            mod_nombre.Text = query.Nombre;
            mod_apodo.Text = query.Apodo;
            mod_ciudad.Text = query.Ciudad;
            mod_telefono.Text = query.Telefono;
            mod_email.Text = query.Email;
            mod_password.Text = query.Password;
            modfecha.Text = query.Fecha_Nacimiento;
            mod_perfil.ImageUrl = query.Imagen_Perfil;


            test.Text = query.Password;
        }
    }
}