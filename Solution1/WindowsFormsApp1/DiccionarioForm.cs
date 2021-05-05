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
    public partial class DiccionarioForm : Form
    {
        Diccionario oDiccionario = new Diccionario();
        public DiccionarioForm()
        {
            InitializeComponent();
           
        }
        private void DiccionarioForm_Load(object sender, EventArgs e)
        {
            oDiccionario.llenarDiccionario("charcheroso", "que es desarreglado, desaseado, viejo");
            oDiccionario.llenarDiccionario("rondalla", "grupo de bandas");
            oDiccionario.llenarDiccionario("atelofobia", "fobia a la imperfección, miedo extremo a no alcanzar la perfección");
            oDiccionario.llenarDiccionario("huachicolero", "En México, persona que se dedica al robo y venta ilegal de combustible ");
            oDiccionario.llenarDiccionario("sellador", "que es desarreglado, Masilla de poliuretano y sirve para reparar, rellenar y sellar juntas de hormigón");
            oDiccionario.llenarDiccionario("persuadir", "conseguir con razones y argumentos que una persona actúe o piense de un modo determinado.");
            oDiccionario.llenarDiccionario("eslora", "Longitud de un barco de proa a popa");
            oDiccionario.llenarDiccionario("sinóptico", "Que presenta las partes principales de un asunto de manera clara, rápida y resumida");
            oDiccionario.llenarDiccionario("acciacos", "juegos que cada tres años se realizaban en Roma ");
            oDiccionario.llenarDiccionario("tuitear", "comunicarse por medio de tuits (en la red social Twitter)");
            
            foreach (var item in oDiccionario.miDiccionario.OrderBy(x => x.Key))
            {
                Lbdic.Items.Add(item.Key);
                
            }           
            
        }

        private void Lbdic_SelectedIndexChanged(object sender, EventArgs e)
        {
            String itemSelec = Lbdic.SelectedItem.ToString();
            TBdef.Text = oDiccionario.miDiccionario[itemSelec];

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
