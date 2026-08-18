using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TM_TIPOS_DE_VISIBILIDAD
    {
        [Key]
        public int Id { get; set; }
        public string Tipo_De_Visibilidad { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public DateTime? Fecha_Mod { get; set; }
    }
}
