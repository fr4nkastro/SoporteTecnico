using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class viewOrdenTrabajo
    {
        public DateTime fechaInicio { get; set; }   
        public DateTime fechaFinal { get; set; }
        public decimal DetalleID { get; set; }
       public decimal ClienteID  { get; set; }
       public decimal TecnicoID  { get; set; }
       public decimal ServicioID  { get; set; }
        public decimal ContratoID { get; set; }
       public decimal OrdenTrabajoID  { get; set; }
       public string Cliente  { get; set; }
       public string Tecnico  { get; set; }
       public string Servicio  { get; set; }

    }
}
