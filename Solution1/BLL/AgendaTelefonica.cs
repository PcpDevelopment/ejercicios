using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgendaTelefonica
    {
        
        public Dictionary<String, String> agendaTel = new Dictionary<String, String>();


        public void llenarAgenda(String numTel, String nom )
        {
            agendaTel.Add(numTel,nom );
        }
    }
}
