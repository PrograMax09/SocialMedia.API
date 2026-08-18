using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTO.Cuentas
{
    public class CreateContentDTO
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Media { get; set; }
        public string Visibilidad { get; set; }
    }
}
