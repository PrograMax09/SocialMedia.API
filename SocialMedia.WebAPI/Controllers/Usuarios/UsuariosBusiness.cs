using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Usuarios;
using Entities.AppContext;

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
            throw new NotImplementedException();
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
