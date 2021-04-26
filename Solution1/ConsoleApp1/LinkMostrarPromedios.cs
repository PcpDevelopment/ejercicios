using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace ConsoleApp1
{
    public class LinkMostrarPromedios
    {
        PromedioEstudiantes oPromedioEstudiantes = new PromedioEstudiantes();

         public void llenar()// promedio estudiantes
        {
            oPromedioEstudiantes.llenarLista("jesus", 79);
            oPromedioEstudiantes.llenarLista("carlos", 80);
            oPromedioEstudiantes.llenarLista("reina", 81);
            oPromedioEstudiantes.llenarLista("pido", 60);
            oPromedioEstudiantes.llenarLista("carlito", 90);
            oPromedioEstudiantes.llenarLista("sandra", 85);

            Console.WriteLine("los estudiantes y sus notas son: ");

            foreach (PromedioEstudiantes item in oPromedioEstudiantes.listaEstudiantes)
            {
                Console.WriteLine("nombre: " + item.nombreEstudiantes + " /" + " Nota: " + item.notasEstudiantes);
            }

        }
         public void CalculoPromedio()// promedio estudiantes
        {
            Console.WriteLine("");
            oPromedioEstudiantes.PromedioNotas();
            Console.WriteLine("El Promedio de sus notas es: " + oPromedioEstudiantes.promedio);
        }

         public void NotaMayor()// promedio estudiantes
        {
            Console.WriteLine("");
            oPromedioEstudiantes.CalificacionMayor();
            foreach (PromedioEstudiantes item in oPromedioEstudiantes.listaEstudiantes)
            {
                Console.WriteLine("calificaciones de mayor a menor: " + item.nombreEstudiantes + " " + item.notasEstudiantes);
            }

        }

         public void NotaMenor()// promedio estudiantes
        {
            Console.WriteLine("");
            oPromedioEstudiantes.CalificacionMenor();
            foreach (PromedioEstudiantes item in oPromedioEstudiantes.listaEstudiantes)
            {
                Console.WriteLine("calificaciones de menor a mayor: " + item.nombreEstudiantes + " " + item.notasEstudiantes);
            }

        }

         public void llamadaPromedioEstudiantes()// promedio estudiantes
        {
            llenar();
            CalculoPromedio();
            NotaMayor();
            NotaMenor();

        }
    }
}
