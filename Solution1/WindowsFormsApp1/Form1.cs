using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelContenedor(new DiccionarioForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelContenedor(new SalonDeClasesForm());
        }

        public void PanelContenedor(object obj)
        { 
            if(Pcontenedor.Controls.Count > 0)
            {
                Pcontenedor.Controls.RemoveAt(0);
              
            }

            Form form = obj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Pcontenedor.Controls.Add(form);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelContenedor(new AtencionAlClienteForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelContenedor(new GastosDelMesForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelContenedor(new AgendaTelefonicaForm());
        }
    }
}
