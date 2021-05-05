using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace ConsoleApp1
{
    class LinkGastosDelMes
    {
        GastosDelMes oGastosDelMes = new GastosDelMes();

        public void llenandooListaGastoMes()
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
        }

        public void OrgnizandoYmostrandoGastosPorDia()
        {
            oGastosDelMes.OrganizarListaPorDias();

            foreach(GastosDelMes item in oGastosDelMes.ListaGastosMes)
            {
                Console.WriteLine("fecha: " + item.dia + " /dia: " + item.DiaDeLaSemana + "/ Monto: " + item.gasto);
            }
        }
   
        public void Organizando_MostrandoGastosPorMonto()
        {
            Console.WriteLine();
            oGastosDelMes.OrganizarPorGastos();
            foreach (GastosDelMes item in oGastosDelMes.ListaGastosMes)
            {
                Console.WriteLine("fecha: " + item.dia + "/ dia: " + item.DiaDeLaSemana + "/ Monto: " + item.gasto);
            }
        }
        public void MostrarSuma()
        {
            Console.WriteLine();
            Console.WriteLine("la suma total de todo es: " + oGastosDelMes.sumaDeTodo);
        }
        
    }
}
