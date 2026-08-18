using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Usuarios;

namespace BusinessLogic.Usuarios
{
    public interface IUsuariosBusiness
    {
        ReadUserDTO Get(string correo);
        IEnumerable<ReadUserDTO> Get();
        //IEnumerable<>
        ReadUserDTO CreateUser(CreateUserDTO user);
    }
}
