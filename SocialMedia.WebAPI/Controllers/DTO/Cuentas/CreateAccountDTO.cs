using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO.Cuentas
{
    public class CreateAccountDTO
    {
        public string Nombre_Cuenta { get; set; }
        public string Contrasena { get; set; }
        public string Usuario { get; set; }
        public string Bio { get; set; }
        public string Foto { get; set; }
    }
}
