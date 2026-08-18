using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace BusinessLogic.DTO.Cuentas
{
    public class ReadAccountDTO
    {
        public string Nombre { get; set; }
        public string Bio { get; set; }
        public string Foto { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public TM_USUARIOS? Usuario { get; set; }
        public int Id_Usuario { get; set; }
    }
}
