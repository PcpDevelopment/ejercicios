using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class PromedioEstudiantes
    {
        public int notasEstudiantes;
        public string nombreEstudiantes;
        public float promedio;
        int contador;
        float sumar;

        public List<PromedioEstudiantes> listaEstudiantes = new List<PromedioEstudiantes>();


        public void llenarLista(String nom, int notas )
        {
            listaEstudiantes.Add(new PromedioEstudiantes { nombreEstudiantes = nom, notasEstudiantes = notas });
            sumar = sumar + notas;
        }

        public void PromedioNotas()
        {
            contador = listaEstudiantes.Count;
            
            promedio = sumar / contador;

        }
        public void CalificacionMayor()
        {            
            IEnumerable<PromedioEstudiantes> lis = listaEstudiantes.AsQueryable().OrderByDescending(listaEstudiantes => listaEstudiantes.notasEstudiantes);
            listaEstudiantes = lis.ToList();
        }
        public void CalificacionMenor()
        {
            IEnumerable<PromedioEstudiantes> lis = listaEstudiantes.AsQueryable().OrderBy(listaEstudiantes => listaEstudiantes.notasEstudiantes);
            listaEstudiantes = lis.ToList();
        }


    }

    
}
