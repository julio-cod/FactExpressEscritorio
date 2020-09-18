using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactExpressDesktop.Modelos
{
    public class PedidoModel
    {
        public int Codigo { get; set; }
        public int CodUsuarioDelSistema { get; set; }
        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string LugarEntrega { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal TotalDescuentos { get; set; }
        public decimal Total { get; set; }
        public decimal TotalGanancia { get; set; }
        public string Estado { get; set; }
        public string Comentario { get; set; }

    }
}
