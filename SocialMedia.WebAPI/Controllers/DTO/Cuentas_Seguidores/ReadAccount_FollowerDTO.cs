using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO.Cuentas
{
    public class ReadAccount_FollowerDTO
    {
        public ReadAccountDTO Cuenta { get; set; }
        public ReadAccountDTO CuentaSeguida { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
