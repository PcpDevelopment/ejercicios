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
    public partial class AtencionAlClienteForm : Form
    {
        AtencionAlCliente oAtencionCliente = new AtencionAlCliente();
        ListViewItem item = new ListViewItem();
        int contador = 1; 
        
        
        Queue<String> lisCliente = new Queue<string>();
        public AtencionAlClienteForm()
        {
            InitializeComponent();
        }        

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            String nombre = TbCliente.Text;
            oAtencionCliente.llenarListaClientes(nombre);
            lisCliente.Enqueue(nombre);

            foreach (var obj in oAtencionCliente.ListaCliente)
            {
                if(String.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Campos vacios");
                }
                else
                {
                    item = new ListViewItem(obj);
                    item.SubItems.Add("cliente numero: " + contador++);
                    LvClientes.Items.Add(item);
                }               
                               
             }
            TbCliente.Clear();
            oAtencionCliente.ListaCliente.Clear();
            
            
        }

       
    }
}
