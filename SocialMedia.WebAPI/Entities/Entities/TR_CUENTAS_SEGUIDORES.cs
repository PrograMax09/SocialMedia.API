using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TR_CUENTAS_SEGUIDORES
    {
        [Key]
        public int Id { get; set; }

        public int Id_Cuenta { get; set; }

        [ForeignKey("Id_Cuenta")]
        public TM_CUENTAS? Cuenta { get; set; }

        public int Id_Cuenta_Seguida { get; set; }

        [ForeignKey("Id_Cuenta_Seguida")]
        public TM_CUENTAS? Cuenta_Seguida { get; set; }

        public DateTime? Fecha_Alta { get; set; }
    }
}
