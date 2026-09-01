using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Cuentas;
using Entities.AppContext;
using Microsoft.Identity.Client;

namespace BusinessLogic.Cuentas
{
    public class CuentasBusiness : ICuentasBusiness
    {
        private readonly Context _context;

        public CuentasBusiness(Context context)
        {
            _context = context;
        }
        public ReadAccountDTO CreateAccount(CreateAccountDTO user)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ReadAccountDTO> Get()
        {
            return _context.TM_CUENTAS
                .Select(account => new ReadAccountDTO
                {
                    Nombre = account.Nombre_Cuenta,
                    Bio = account.Bio,
                    Foto = account.Foto,
                    Fecha_Alta = (DateTime)account.Fecha_Alta,
                    Usuario = account.Usuario,
                    Id_Usuario = account.UsuarioId
                })
                .ToList();
        }
        public ReadAccountDTO Get(string nombre)
        {
            return _context.TM_CUENTAS.Where(a => a.Nombre_Cuenta == nombre)
                .Select(account => new ReadAccountDTO
                {
                    Nombre = account.Nombre_Cuenta,
                    Bio = account.Bio,
                    Foto = account.Foto,
                    Fecha_Alta = (DateTime)account.Fecha_Alta,
                    Usuario = account.Usuario,
                    Id_Usuario = account.UsuarioId
                })
                .ToList().FirstOrDefault();
        }

        public ReadAccountDTO GetByMail(string correo)
        {
            return _context.TM_CUENTAS.Where(a => a.Usuario.Correo == correo)
                .Select(account => new ReadAccountDTO
                {
                    Nombre = account.Nombre_Cuenta,
                    Bio = account.Bio,
                    Foto = account.Foto,
                    Fecha_Alta = (DateTime)account.Fecha_Alta,
                    Usuario = account.Usuario,
                    Id_Usuario = account.UsuarioId
                })
                .ToList().FirstOrDefault();
        }
    }
}