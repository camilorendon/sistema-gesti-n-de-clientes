using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes
{
    internal class Cliente
    {
        //crear todas  las variables para que esten aqui dentro y cosa de tenela en
        //un solo objeto
       
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Telefono { get; set; }
        public string TarjetaDeCredito { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }
        
    }
}
