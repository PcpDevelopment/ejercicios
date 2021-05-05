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
    public partial class SalonDeClasesForm : Form
    {        
        string estudiantes;
        string  notas;
        float promedio;
        float suma;
        string estu;
        int not;
        int contador = 0;
                     
        PromedioEstudiantes oPromedioEstudiantes = new PromedioEstudiantes();
        List<SalonDeClasesForm> comparar = new List<SalonDeClasesForm>();
        List<SalonDeClasesForm> probando = new List<SalonDeClasesForm>();
        public SalonDeClasesForm()
        {
            InitializeComponent();
            listVEstud.View = View.Details;
        }
        private void btnAgregarEstudiantes_Click(object sender, EventArgs e)
        {            

            try
            {
                contador++;
                estudiantes = txtEstud.Text;
                notas = txtNotasEst.Text;

                if (!String.IsNullOrEmpty(estudiantes) && !String.IsNullOrEmpty(notas.ToString()))
                {                   
                    int digitos;

                    if (int.TryParse(txtNotasEst.Text, out digitos))
                    {
                        
                        oPromedioEstudiantes.llenarLista(estudiantes, digitos);
                        suma = suma + int.Parse(notas);
                        promedio = suma / contador;
                        comparar.Add(new SalonDeClasesForm { estu = estudiantes, not = digitos });
                        ListViewItem i = new ListViewItem(oPromedioEstudiantes.listaEstudiantes[0].nombreEstudiantes, 0);

                        i.SubItems.Add(oPromedioEstudiantes.listaEstudiantes[0].notasEstudiantes.ToString());

                        listVEstud.Items.Add(i);
                        oPromedioEstudiantes.listaEstudiantes.Clear();
                        txtEstud.Clear();
                        txtNotasEst.Clear();
                        label1.Text = String.Format("{0:0.0 }", promedio);
                    }
                    else
                    {
                        MessageBox.Show("solo se pueden digitar numeros");
                    }
                }
                else
                {
                    MessageBox.Show("hay campos vacios");
                }                          
 
            }
            catch(Exception o)
            {
               
            }

           

        }
        private void listVEstud_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            Int32 colIndex = Convert.ToInt32(e.Column.ToString());
            var enu = from num in comparar orderby num.not descending select num;
                
            if ( listVEstud.Columns[colIndex].Text == "Ordenar▲")
            {
                listVEstud.Items.Clear();

                enu = from num in comparar orderby num.not descending select num;
                foreach(var item in enu)
                {
                    ListViewItem yo = new ListViewItem(item.estu, 0);
                   
                    yo.SubItems.Add(item.not.ToString());
                    listVEstud.Items.Add(yo);                    
                }
            }

             var enus = from num in comparar orderby num.not ascending select num;

            if (listVEstud.Columns[colIndex].Text == "Ordenar▼")
            {
                listVEstud.Items.Clear();
                                
                foreach (var item in enus)
                {
                    ListViewItem yo = new ListViewItem(item.estu, 0);

                    yo.SubItems.Add(item.not.ToString());
                    listVEstud.Items.Add(yo);

                }
            }

        }

        private void listVEstud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SalonDeClasesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
