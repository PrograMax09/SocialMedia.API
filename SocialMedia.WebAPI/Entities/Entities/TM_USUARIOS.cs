using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TM_USUARIOS
    {
        [Key]
        public int Id { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public DateTime? Fecha_Mod { get; set; }
    }
}
