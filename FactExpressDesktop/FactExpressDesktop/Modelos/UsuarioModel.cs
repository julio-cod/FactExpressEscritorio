using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactExpressDesktop.Modelos
{
    public class UsuarioModel
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }

    }
}
