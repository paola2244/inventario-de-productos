using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFacturacion.Model
{
    public class Caja
    {
        public int IdCaja { get; set; }
        public decimal  MontonInicial { get; set; }
        public decimal MontoFinal { get; set; }
        public decimal TotalVentasEfectivo { get; set; }
        public decimal TotalVentasOnline { get; set; }
        public decimal Total { get; set; }
        public decimal Diferencia  { get; set; }

        public string NombreCaja => $"Caja {IdCaja}";
    }
}
