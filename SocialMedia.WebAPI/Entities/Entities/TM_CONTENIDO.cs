using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TM_CONTENIDO
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Media { get; set; }
        public int Id_Visibilidad { get; set; }

        [ForeignKey("Id_Visibilidad")]
        public TM_TIPOS_DE_VISIBILIDAD? Visibilidad { get; set; }
        public int Id_Cuenta  { get; set; }

        [ForeignKey("Id_Cuenta")]
        public TM_CUENTAS? Cuenta { get; set; }
        public DateTime? Fecha_Alta { get; set; }
    }
}
