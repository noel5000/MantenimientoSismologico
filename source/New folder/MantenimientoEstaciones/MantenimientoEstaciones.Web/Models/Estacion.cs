using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MantenimientoEstaciones.Web.Models
{
    public class Estacion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public string Altura { get; set; }
        public DateTime? FechaInstalacion { get; set; }
        public string Fotos { get; set; }
        public string Contactos { get; set; }
        public string Equipos { get; set; }
        public string TipoTx { get; set; }

        public List<Mantenimiento> Mantenimientos { get; set; }
        public int Index { get; set; }
    }

    public class Mantenimiento 
    {
    public DateTime Fecha { get; set; }
        public decimal Estacion { get; set; }
        public string FallaTecnica { get; set; }
        public string PosibleCausa { get; set; }
        public string Observaciones { get; set; }
        public bool Solucionado { get; set; }
        public DateTime? FechaSolucion { get; set; }
        public string Solucion { get; set; }

        public int Index { get; set; }
    }
}
