using Pacial_1._1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacial_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList envios = new ArrayList();
        private void btnAltaEnvio_Click(object sender, EventArgs e)
        {
            Envio env = new Envio();

            env = new Envio();//<<create>> Envio()//1
            env.AgregarCosto(new Fijo("Peaje puente Zárate", 300));//nuev1 : Fijo //2
            env.AgregarCosto(new Variable("Combustible", 1500.5, 500));//nuev2:Variable 2
            envios.Add(env);//3

            env = new Envio();
            env.AgregarCosto(new Fijo("Peaje túnel", 300));
            env.AgregarCosto(new Variable("Horas de conducción", 500, 10));
            envios.Add(env);
        }

        private void btnListarCostos_Click(object sender, EventArgs e)
        {      
           
            foreach (Envio env in envios )//envi va a recorrer "envios" que es mi ArrayList creado arriba
            {
                tbxLista.Text += env.VerDetalle() + "\r\n";
                tbxLista.Text += $"Total:$ {env.ValorTotal,10:f2}\r\n\r\n";//imprimimos el valor total de envi que recorre los envios.
            }
            
            
        }
    }
}
