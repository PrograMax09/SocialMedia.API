using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TM_CUENTAS
    {
        [Key]
        public int Id { get; set; }
        public string Nombre_Cuenta { get; set; }
        public string Bio { get; set; }
        public string Foto { get; set; }
        public string Contrasena { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public TM_USUARIOS? Usuario { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public DateTime? Fecha_Mod { get; set; }
    }
}
