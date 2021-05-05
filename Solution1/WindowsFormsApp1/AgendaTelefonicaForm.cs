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
            
            oAgenda.llenarAgendaTelefonica(nom, tel);
                        
            if(String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(tel))
            {
                MessageBox.Show("faltan datos");
            }
            else
            {
                LbAgenda.Items.Add(oAgenda.ListaAgendaTelefonica[contador].nombre);
                TbNombre.Clear();
                TbTel.Clear();
            }

            if (!String.IsNullOrEmpty(tbMostrarTel.Text))
            {
                tbMostrarTel.Clear();
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
