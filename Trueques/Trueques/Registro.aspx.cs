using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trueques
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string confirmar, prev, previoemail;
        public int dias, años, años2;

        protected void cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                //si hay una archivo.
                string nombreArchivo = FileUpload1.FileName;
                string ruta = "~/Imagenes/Perfil/" + nombreArchivo;
                FileUpload1.SaveAs(Server.MapPath(ruta));

                Label3.Text = "Se guardó la imagen. y su ruta es" + Environment.NewLine + ruta;

            }
            else
            {
                Label3.Text = "No se eligio Imagen";
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //if (Calendar1.Visible)
            //{
            //    Calendar1.Visible = false;
            //}
            //else
            //{
            //    Calendar1.Visible = true;
            //}
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

            //fecha.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            //Calendar1.Visible = false;

            //var today = DateTime.Today;
            //var birthdate = Calendar1.SelectedDate;
            //// Calculate the age.
            //var age = today.Year - birthdate.Year;

            //DateTime fechahoy = System.DateTime.Today;
            //DateTime fechanacimiento = Calendar1.SelectedDate;
            //TimeSpan tspan = fechahoy - fechanacimiento;
            //años = System.DateTime.Now.Year; //- Calendar1.SelectedDate.Year;
            //años2 = Calendar1.SelectedDate.Year;
            ////if (System.DateTime.Now.Subtract(fechanacimiento.AddYears(años)).TotalDays < 0)
            //int compa = años-años2;
            //Convert.ToChar(compa);
            //int ent = Convert.ToInt32(Calendar1.SelectedDate.Year);
            //if (age > 1)
            //{
            //    Label3.Text = "Funciona if";
            //}
            //{
            //    Label3.Text = age.ToString();
            //}
            //dias = tspan.Days;

            //Label3.Text = dias.ToString();
            //Label3.Text = Convert.ToString(años);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (! IsPostBack)
            //{
            //    Calendar1.Visible = false;
            //}
        }

        protected void registrar_Click(object sender, EventArgs e)
        {
            prev = this.email.Text;
            var consulta = from m in db.Usuario
                           where m.Email == prev
                           select m;

            foreach (var x in consulta)
            {
                previoemail = x.Email;
                //Label2.Text = previoemail;
            }


            string email = this.email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                Usuario nuevo = new Usuario();
                nuevo.Nombre = nombre.Text;
                nuevo.Apodo = apodo.Text;
                nuevo.Ciudad = ciudad.Text;
                nuevo.Telefono = telefono.Text;
                nuevo.Email = this.email.Text;
                nuevo.Nombre_Mascota = nombre_mascota.Text;
                nuevo.Password = password.Text;
                nuevo.Fecha_Nacimiento = dia.Text + "/" + mes.Text + "/" + año.Text;
                //nuevo.Imagen_Perfil = ruta;
                confirmar = conpassword.Text;
                Label1.Text = "";

                string pass = password.Text;
                string mascota = nombre_mascota.Text;
                if (pass.Length >= 8)
                {
                    //Regex regex2 = new Regex(@"^(([0-9]+)([A-Z]+)([a-z]+)([!@#$%^&*()_+=\[{\]};:<>|./?,-]))$");
                    //Regex regex2 = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z]).{8,}$");
                    Regex regex2 = new Regex("^(?=.*[a-z])(?=.*[!@#$%^&*()_+<>|./?,-])(?=.*[A-Z])(?=.*[^a-zA-Z]).{8,}$");
                    Match match2 = regex2.Match(pass);
                    if (match2.Success)
                    {
                        if (nuevo.Password == confirmar)
                        {

                            if (mascota.Length > 0)
                            {
                                if (previoemail != this.email.Text)
                                {
                                    string d = dia.Text, m = mes.Text, a = año.Text;
                                    if (d.Length > 0 && m.Length > 0 && a.Length > 0)
                                    {
                                        int diferencia = 2019 - int.Parse(año.Text);
                                        if (diferencia >= 18)
                                        {
                                            if (FileUpload1.HasFile)
                                            {
                                                //si hay una archivo.
                                                string nombreArchivo = FileUpload1.FileName;
                                                string ruta = "~/Imagenes/Perfil/" + nombreArchivo;
                                                FileUpload1.SaveAs(Server.MapPath(ruta));
                                                nuevo.Imagen_Perfil = ruta;
                                                //Label3.Text = "Se guardó la imagen. y su ruta es" + Environment.NewLine + ruta;
                                                db.Usuario.InsertOnSubmit(nuevo);
                                                db.SubmitChanges();
                                                Response.Redirect("Login.aspx");
                                            }
                                            else
                                            {
                                                Label3.Text = "No se eligio Imagen";
                                                nomascota.Text = "";
                                                nopass.Text = "";
                                                nopass2.Text = "";
                                                newfecha.Text = "";
                                            }

                                        }
                                        else
                                        {
                                            newfecha.Text = "Debes ser mayor de edad";
                                            nomascota.Text = "";
                                            nopass.Text = "";
                                            nopass2.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        newfecha.Text = "Indica una fecha";
                                        nomascota.Text = "";
                                        nopass.Text = "";
                                        nopass2.Text = "";
                                    }

                                }
                                else
                                {
                                    Label1.Text = "Email ya registrado";
                                    nomascota.Text = "";
                                    nopass.Text = "";
                                    nopass2.Text = "";

                                }
                            }
                            else
                            {
                                nomascota.Text = "Indica un nombre";
                                nopass.Text = "";
                                nopass2.Text = "";
                                Label1.Text = "";
                            }
                        }
                        else
                        {
                            nopass.Text = "Contraseñas no iguales";
                            nopass2.Text = "Contraseñas no iguales";
                            //password.Text = "";
                            conpassword.Text = "";
                            Label1.Text = "";
                        }

                    }
                    else
                    {
                        nopass.Text = "Deben ser Minimo 8 caracteres, 1 Mayuscula, 1 Minuscula, 1 Numero, 1 Simbolo";
                        nopass2.Text = "Deben ser Minimo 8 caracteres, 1 Mayuscula, 1 Minuscula, 1 Numero, 1 Simbolo";
                    }

                }
                else
                {
                    nopass.Text = "Deben ser Minimo 8 caracteres, 1 Mayuscula, 1 Minuscula, 1 Numero, 1 Simbolo";
                    nopass2.Text = "Deben ser Minimo 8 caracteres, 1 Mayuscula, 1 Minuscula, 1 Numero, 1 Simbolo";
                }

            }
            else
            {
                Label1.Text = "Email no cumple el formato requerido (ejemplo@dominio.com)";
            }



        } //fin funcion
    }
}