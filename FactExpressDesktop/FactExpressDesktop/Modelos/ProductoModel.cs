using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactExpressDesktop.Modelos
{
    public class ProductoModel
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }

    }
}
