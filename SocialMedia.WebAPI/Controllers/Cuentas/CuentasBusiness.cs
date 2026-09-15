using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Cuentas;
using Entities.AppContext;
using Entities.Entities;
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

        public ReadAccountDTO CreateAccount(CreateAccountDTO account)
        {
            if (string.IsNullOrWhiteSpace(account.Nombre_Cuenta) || string.IsNullOrWhiteSpace(account.Contrasena))
            {
                throw new ArgumentException("Account name or password is empty.");
            }

            var existingAccount = _context.TM_CUENTAS
                .Any(a => a.Nombre_Cuenta.ToLower() == account.Nombre_Cuenta.ToLower());
            if (existingAccount)
            {
                throw new ArgumentException("Account name is already in use.");
            }

            var user = _context.TM_USUARIOS
                .FirstOrDefault(u => u.Correo == account.Usuario);
            if (user == null)
            {
                throw new ArgumentException("No user with the selected mail.");
            }

            var nuevaCuenta = new TM_CUENTAS
            {
                Nombre_Cuenta = account.Nombre_Cuenta,
                Contrasena = account.Contrasena,
                UsuarioId = user.Id,
                Bio = account.Bio,
                Foto = account.Foto,
                Fecha_Alta = DateTime.Now
            };

            _context.TM_CUENTAS.Add(nuevaCuenta);
            _context.SaveChanges();

            return new ReadAccountDTO
            {
                Nombre = nuevaCuenta.Nombre_Cuenta,
                Bio = nuevaCuenta.Bio,
                Foto = nuevaCuenta.Foto,
                Fecha_Alta = (DateTime)nuevaCuenta.Fecha_Alta,
                Usuario = user,
                Id_Usuario = user.Id
            };
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