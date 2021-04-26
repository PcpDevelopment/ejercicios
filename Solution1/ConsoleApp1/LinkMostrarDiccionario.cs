using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace ConsoleApp1
{
    class LinkMostrarDiccionario
    {
        String entrada;
        Diccionario oDiccionario = new Diccionario();

        public void LLamadaDiccionario()
        {
            oDiccionario.llenarDiccionario("antipersona", "Dicho de una mina: Preparada para, al ser pisada, matar o mutilar a una persona.");
            oDiccionario.llenarDiccionario("deportivo", "zapatillas de deporte.");
            oDiccionario.llenarDiccionario("orange", "internet malo");
            oDiccionario.llenarDiccionario("pld", "ladrones");
            oDiccionario.llenarDiccionario("intagsa", "prestamos baratos");

            Console.WriteLine();
            Console.WriteLine("estos son los elementos que tiene el diccionario, escriba el nombre para ver su definicion");
            Console.WriteLine();
            foreach(var item in oDiccionario.miDiccionario.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("escriba el nombre de un elemento de la lista para ver su definicion");
            Console.WriteLine();
            entrada = Console.ReadLine();
            if (oDiccionario.miDiccionario.ContainsKey(entrada))
            {
                Console.WriteLine(oDiccionario.miDiccionario[entrada]);
            }
            else
            {
                Console.WriteLine("el valor no se encuentra en el diccionario");
            }

        }

    }
}
