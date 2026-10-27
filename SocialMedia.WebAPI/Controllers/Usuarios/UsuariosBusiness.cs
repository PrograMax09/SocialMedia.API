using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Cuentas;
using BusinessLogic.DTO.Usuarios;
using Entities.AppContext;
using Entities.Entities;

namespace BusinessLogic.Usuarios
{
    public class UsuariosBusiness : IUsuariosBusiness
    {
        private readonly Context _context;

        public UsuariosBusiness (Context context)
        {
            _context = context;
        }
    public ReadUserDTO CreateUser(CreateUserDTO user)
        {
            // 1. Validate the input
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
    
            if (string.IsNullOrWhiteSpace(user.Correo) ||
                string.IsNullOrWhiteSpace(user.Contrasena))
            {
                throw new ArgumentException("Email or password is empty.");
            }

            // 2. Check whether the email is already registered
            var existingUser = _context.TM_USUARIOS
                .Any(u => u.Correo.ToLower() == user.Correo.ToLower());

            if (existingUser)
            {
                throw new ArgumentException("Email is already in use.");
            }

            // 3. Create the new user
            var nuevoUsuario = new TM_USUARIOS
            {
                Correo = user.Correo,
                Contrasena = user.Contrasena,
                Fecha_Alta = DateTime.Now
            };

            // 4. Save the user to the database
            _context.TM_USUARIOS.Add(nuevoUsuario);
            _context.SaveChanges();

            // 5. Return the ReadUserDTO
            return new ReadUserDTO
            {
                Correo = nuevoUsuario.Correo,
                Descripcion = nuevoUsuario.Descripcion,
                Fecha_Alta = (DateTime)nuevoUsuario.Fecha_Alta
            };
        }


        public ReadUserDTO Get(string correo)
        {
            // ctrl + k + c to comment
            //var user = _context.TM_USUARIOS.Where(u => u.Correo == correo).ToList().FirstOrDefault();
            //ReadUserDTO readUserDTO = new ReadUserDTO{
            //    Correo = user.Correo,
            //    Descripcion = user.Descripcion,
            //    Fecha_Alta = (DateTime)user.Fecha_Alta
            //};
            //return readUserDTO;

            return _context.TM_USUARIOS.Where(u => u.Correo == correo)
                .Select(user => new ReadUserDTO
                {
                    Correo = user.Correo,
                    Descripcion = user.Descripcion,
                    Fecha_Alta = (DateTime)user.Fecha_Alta
                })
                .ToList().FirstOrDefault();
        }

        public IEnumerable<ReadUserDTO> Get()
        {

            //var userList = _context.TM_USUARIOS.ToList();                  cojer todo de tm_Usuarios
            //List<ReadUserDTO> readUserDTOs = new List<ReadUserDTO> ();     Crear objeto DTO
            //foreach (var user in userList)                                 Convertir en lista DTO
            //{
            //    ReadUserDTO aux = new ReadUserDTO ();
            //    aux.Correo = user.Correo;
            //    aux.Descripcion = user.Descripcion;
            //    aux.Fecha_Alta = (DateTime)user.Fecha_Alta;
            //    readUserDTOs.Add(aux);
            //}
            //return readUserDTOs;
            return _context.TM_USUARIOS
                .Select(user => new ReadUserDTO
                {
                    Correo = user.Correo,
                    Descripcion = user.Descripcion,
                    Fecha_Alta = (DateTime)user.Fecha_Alta
                })
                .ToList();
        }
    }
}
