using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Cuentas;

namespace BusinessLogic.Cuentas
{
    public interface ICuentasBusiness
    {
        ReadAccountDTO CreateAccount(CreateAccountDTO createAccount);
        ReadAccountDTO Get(string nombre);
        IEnumerable<ReadAccountDTO> Get();
        ReadAccountDTO GetByMail(string correo);
    }
}
