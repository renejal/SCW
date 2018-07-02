using SCW.PRESENTACION;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCW
{
    public partial class Form1 : Form
    {
        #region atributos
        clsControl control = new clsControl();
        int s = 55;
        int m = 59;
        int h = 0;
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
        
        private void ObtenerDispositivosConectados()
        {
            foreach (HtmlElement etiqueta in navegador.Document.All)
            {
                if (etiqueta.GetAttribute("classname").Contains("col-xs-10 span-fixed deviceName"))
                {

                    cbox_1.Items.Add(etiqueta.InnerText);

                }
            }
            
        }
        private void navegarAcontrol()
        {
            HtmlElement btnControlTime = navegador.Document.GetElementById("net-control");
            btnControlTime.InvokeMember("click");
        }
        private void datos_cargados(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            this.IniciarSesion();
             //if(navegador.DocumentCompleted)
           // this.navegarAcontrol();

        }  
         private void button1_Click(object sender, EventArgs e)
         {
             
             this.timer1.Enabled = true;
             
         }

         private void btn_iniciar2_Click(object sender, EventArgs e)
         {

             
             
           
           
 
         }
         
         private void timer1_Tick(object sender, EventArgs e)
         {

             //this.CuentaRegresiva();
             this.cuentaProgresiva();
           
             
             
         }
         private void cuentaProgresiva()
         {
             if (s <= 59)
             {
                 this.lb_timeRest.Text = h + ":" + m + ":" + s;
                 s++;
             }
             else if (m < 59)
             {
                 s = 00;
                 m++;
             }
             else if (h < 59)
             {
                 m = 00;
                 s = 00;
                 h++;
             }
             else
             {
                 this.lb_timeRest.Text = "00:00:00";
             }
         }
         private void CuentaRegresiva()
         {
             if (s>=0)
             {
                 this.lb_timeRest.Text = h + ":" + m + ":" + s;
                 s--;
             }
             else if (m>0)
             {
                 s = 59;
                 m--;
             }
             else if(m>0)
             {
                 m=59;
                 s = 60;
                 h--;
             }
             else
             {
                 this.lb_timeRest.Text = "00:00:00";
             }
         }
         private void btn_pausa1_Click(object sender, EventArgs e)
         {
             timer1.Stop();
         }

         private void btn_pausar2_Click(object sender, EventArgs e)
         {
            
            // this.ObtenerDispositivosConectados();
            
         }


    }
}
