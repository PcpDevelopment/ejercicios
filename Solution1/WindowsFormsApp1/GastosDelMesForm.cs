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
    public partial class GastosDelMesForm : Form
    {
        GastosDelMes oGastosDelMes = new GastosDelMes();
        public GastosDelMesForm()
        {
            InitializeComponent();
        }        
        private void GastosDelMesForm_Load(object sender, EventArgs e)
        {
            oGastosDelMes.llenarListaGastosMes(1, 500, "lunes");
            oGastosDelMes.llenarListaGastosMes(2, 860, "martes");
            oGastosDelMes.llenarListaGastosMes(3, 700, "miercoles");
            oGastosDelMes.llenarListaGastosMes(4, 150, "jueves");
            oGastosDelMes.llenarListaGastosMes(5, 225, "viernes");
            oGastosDelMes.llenarListaGastosMes(6, 621, "sabado");
            oGastosDelMes.llenarListaGastosMes(7, 952, "domingo");
            oGastosDelMes.llenarListaGastosMes(8, 115, "lunes");
            oGastosDelMes.llenarListaGastosMes(9, 325, "martes");
            oGastosDelMes.llenarListaGastosMes(10, 987, "miercoles");
            oGastosDelMes.llenarListaGastosMes(11, 1021, "sabado");
            oGastosDelMes.llenarListaGastosMes(12, 981, "domingo");
            oGastosDelMes.llenarListaGastosMes(13, 186, "lunes");
            oGastosDelMes.llenarListaGastosMes(14, 342, "martes");
            oGastosDelMes.llenarListaGastosMes(15, 901, "miercoles");
            foreach(var item in oGastosDelMes.ListaGastosMes)
            {
                ListViewItem item2 = new ListViewItem(item.dia.ToString());
                item2.SubItems.Add(item.DiaDeLaSemana);
                item2.SubItems.Add(item.gasto.ToString());

                lvGastos.Items.Add(item2);
            }
            oGastosDelMes.sumar();
            label1.Text = oGastosDelMes.sumaDeTodo.ToString();                        
        }
        private void lvGastos_ColumnClick(object sender, ColumnClickEventArgs e)
        {            
            int colulmIn = Convert.ToInt32(e.Column.ToString());

            if(lvGastos.Columns[colulmIn].Text == "Fecha")
            {
                lvGastos.Items.Clear();
                var enu = from num in oGastosDelMes.ListaGastosMes orderby num.dia descending select num;
                foreach (var item3 in enu)
                {
                    ListViewItem item = new ListViewItem(item3.dia.ToString());
                    item.SubItems.Add(item3.DiaDeLaSemana);
                    item.SubItems.Add(item3.gasto.ToString());
                    lvGastos.Items.Add(item);
                } 
            }
            if (lvGastos.Columns[colulmIn].Text == "Gastos")
            {
                lvGastos.Items.Clear();
                var enu = from num in oGastosDelMes.ListaGastosMes orderby num.gasto descending select num;
                foreach (var item3 in enu)
                {
                    ListViewItem item = new ListViewItem(item3.dia.ToString());
                    item.SubItems.Add(item3.DiaDeLaSemana);
                    item.SubItems.Add(item3.gasto.ToString());
                    lvGastos.Items.Add(item);
                }
            }

        }
    }
}
