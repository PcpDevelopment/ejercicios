using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace WindowsFormsApp1
{
    public partial class AgendaTelefonicaForm : Form
    {
        AgendaTelefonica oAgenda = new AgendaTelefonica();
        int contador = 0;
        public AgendaTelefonicaForm()
        {
            InitializeComponent();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String nom = TbNombre.Text;
            string tel = TbTel.Text;
            int digitos;

            try
            {
                if (!String.IsNullOrEmpty(nom) && !String.IsNullOrEmpty(tel))
                {                   
                    if (int.TryParse(TbTel.Text, out digitos))
                    {
                        oAgenda.llenarAgendaTelefonica(nom, digitos.ToString());
                        LbAgenda.Items.Add(oAgenda.ListaAgendaTelefonica[contador].nombre);
                        TbNombre.Clear();
                        TbTel.Clear();
                    }
                    else
                    {
                        MessageBox.Show("solo se pueden digitar numeros");
                    }
                }
                else
                {
                    MessageBox.Show("faltan datos");
                }

                if (!String.IsNullOrEmpty(tbMostrarTel.Text))
                {
                    tbMostrarTel.Clear();
                }
            }
            catch(Exception i)
            {

            }                        
           
            contador = oAgenda.ListaAgendaTelefonica.Count();           
        }
        private void LbAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(LbAgenda.SelectedIndex);
            tbMostrarTel.Text = oAgenda.ListaAgendaTelefonica[indice].telefono;
        }
    }
}
