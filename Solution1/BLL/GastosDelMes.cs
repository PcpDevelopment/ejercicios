using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GastosDelMes
    {
        public int gasto, dia;
        public String DiaDeLaSemana;
        public int sumaDeTodo = 0;
        public List<GastosDelMes> ListaGastosMes = new List<GastosDelMes>();

        public void llenarListaGastosMes(int dias,int gastos, String diaSemana)
        {
            ListaGastosMes.Add(new GastosDelMes { dia = dias, gasto = gastos, DiaDeLaSemana = diaSemana });
            
        }

        public void OrganizarListaPorDias()
        {
            IEnumerable<GastosDelMes> gastar = ListaGastosMes.AsQueryable().OrderByDescending(ListaGastosMes => ListaGastosMes.dia );

            ListaGastosMes = gastar.ToList();
        }

        public void OrganizarPorGastos()
        {
            IEnumerable<GastosDelMes> gastar = ListaGastosMes.AsQueryable().OrderByDescending(ListaGastosMes => ListaGastosMes.gasto);

            ListaGastosMes = gastar.ToList();

        }

        public void sumar()
        {
            for(int i =0; i<ListaGastosMes.Count; i++)
            {
                sumaDeTodo = sumaDeTodo + ListaGastosMes[i].gasto;
            } 
        }

        
    }
}
