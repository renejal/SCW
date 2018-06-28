using SCW.PRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCW
{
    public partial class Form1 : Form
    {
        #region atributos
        clsControl control = new clsControl();
        #endregion 
        public Form1()
        {
            InitializeComponent();
            navegador.Navigate(control.getAtrUrl());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            navegador.ScriptErrorsSuppressed = true;
            navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.datos_cargados);
        }
        private void IniciarSesion()
        {
            try
            {

                //txtPassword.Text = navegador.Document.GetElementById("forgotCaret").InnerText;
                HtmlElement txtlongin = navegador.Document.GetElementById("login-password");
                txtlongin.SetAttribute("value", "jalvinr");
                HtmlElement btnSave = navegador.Document.GetElementById("save");
                btnSave.InvokeMember("click");
            }
            catch (Exception ex)
            {
                Console.Write("error al iniciar sesion");
            }
        }
        //private void ControlTiempo
         private void datos_cargados(object sender, EventArgs e)
        {

            this.IniciarSesion();
            //HtmlElement btnEstado = navegador.Document.GetElementsByTagName("class")
                //    foreach (HtmlElement etiqueta in navegador.Document.All)
                //  {
                //     if (etiqueta.GetAttribute("classname").Contains("g-hovercard yt-uix-sessionlink      spf-link "))
                //     {
                //        txtcategoria.Text = etiqueta.InnerText;
            
                //     }
                //}
           
           

        }

         private void button1_Click(object sender, EventArgs e)
         {
             HtmlElement btnControlTime = navegador.Document.GetElementById("parental-controls");
             btnControlTime.InvokeMember("click");
         }


    }
}
