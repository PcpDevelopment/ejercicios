using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace ConsoleApp1
{
    class Program
    {
        static LinkMostrarPromedios oMostrarPro = new LinkMostrarPromedios();
        static LinkMostrarDiccionario oMostrarDic = new LinkMostrarDiccionario();
        static void Main(string[] args)
        {
            oMostrarPro.llamadaPromedioEstudiantes();
            oMostrarDic.LLamadaDiccionario();
        }               
    }
}
