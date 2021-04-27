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
        GastosDelMes oGastosDelMEs = new GastosDelMes();

        public void llenandooListaGastoMes()
        {
            oGastosDelMEs.llenarListaGastosMes(1, 500, "lunes");
            oGastosDelMEs.llenarListaGastosMes(2, 300, "martes");
            oGastosDelMEs.llenarListaGastosMes(3, 700, "miercoles");
            oGastosDelMEs.llenarListaGastosMes(4, 150, "jueves");
            oGastosDelMEs.llenarListaGastosMes(5, 225, "viernes");
            oGastosDelMEs.llenarListaGastosMes(6, 621, "sabado");
            oGastosDelMEs.llenarListaGastosMes(7, 952, "domingo");
            oGastosDelMEs.llenarListaGastosMes(8, 115, "lunes");
            oGastosDelMEs.llenarListaGastosMes(9, 325, "martes");
            oGastosDelMEs.llenarListaGastosMes(10, 987, "miercoles");
            oGastosDelMEs.llenarListaGastosMes(11, 1021, "sabado");
            oGastosDelMEs.llenarListaGastosMes(12, 981, "domingo");
            oGastosDelMEs.llenarListaGastosMes(13, 186, "lunes");
            oGastosDelMEs.llenarListaGastosMes(14, 342, "martes");
            oGastosDelMEs.llenarListaGastosMes(15, 901, "miercoles");
            oGastosDelMEs.sumar();
        }

        public void OrgnizandoYmostrandoGastosPorDia()
        {
            oGastosDelMEs.OrganizarListaPorDias();

            foreach(GastosDelMes item in oGastosDelMEs.ListaGastosMes)
            {
                Console.WriteLine("fecha: " + item.dia + " /dia: " + item.DiaDeLaSemana + "/ Monto: " + item.gasto);
            }
        }
       
        public void Organizando_MostrandoGastosPorMonto()
        {
            Console.WriteLine();
            oGastosDelMEs.OrganizarPorGastos();
            foreach (GastosDelMes item in oGastosDelMEs.ListaGastosMes)
            {
                Console.WriteLine("fecha: " + item.dia + "/ dia: " + item.DiaDeLaSemana + "/ Monto: " + item.gasto);
            }
        }

        public void MostrarSuma()
        {
            Console.WriteLine();
            Console.WriteLine("la suma total de todo es: " + oGastosDelMEs.sumaDeTodo);
        }
        
    }
}
