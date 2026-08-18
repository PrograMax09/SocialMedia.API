using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TR_CONTENIDO_CUENTAS
    {
        [Key]
        public int Id { get; set; }

        public int Id_Contenido { get; set; }

        [ForeignKey("Id_Contenido")]
        public TM_CONTENIDO? Contenido { get; set; }

        public int Id_Cuenta { get; set; }

        [ForeignKey("Id_Cuenta")]
        public TM_CUENTAS? Cuenta { get; set; }

        public DateTime? Fecha_Alta { get; set; }
    }
}
