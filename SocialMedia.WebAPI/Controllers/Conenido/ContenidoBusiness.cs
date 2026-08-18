using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Cuentas;
using Entities.AppContext;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BusinessLogic.Contenido
{
    public class ContenidoBusiness : IContenidoBusiness
    {
        private readonly Context _context;
        public ContenidoBusiness()
        {
            _context = new Context();
        }
        public IEnumerable<ReadContentDTO> Get()
        {
            List<TM_CONTENIDO> aux = _context.TM_CONTENIDO.Include(content => content.Cuenta).ToList();
            
            return _context.TM_CONTENIDO
                .Select(content => new ReadContentDTO
                {
                    Titulo = content.Titulo,
                    Descripcion = content.Descripcion,
                    Media = content.Media,
                    Cuenta = new ReadAccountDTO
                    {
                        Nombre = content.Cuenta.Nombre_Cuenta,
                        Bio = content.Cuenta.Bio,
                        Foto = content.Cuenta.Foto,
                        Fecha_Alta = (DateTime)content.Cuenta.Fecha_Alta,
                        Usuario = content.Cuenta.Usuario,
                        Id_Usuario = content.Cuenta.UsuarioId
                    },
                    Fecha_Alta = (DateTime)content.Fecha_Alta
                })
                .ToList();
        }
        public IEnumerable<ReadContentDTO> GetOrdered(string modo = "asc")
        {
            var query = _context.TM_CONTENIDO.AsQueryable();

            if (modo.Equals("desc") ) 
                query = query.OrderByDescending(content => content.Fecha_Alta);
            else 
                query = query.OrderBy(content => content.Fecha_Alta);

            return query
                .Select(content => new ReadContentDTO
                {
                    Titulo = content.Titulo,
                    Descripcion = content.Descripcion,
                    Media = content.Media,
                    Cuenta = new ReadAccountDTO
                    {
                        Nombre = content.Cuenta.Nombre_Cuenta,
                        Bio = content.Cuenta.Bio,
                        Foto = content.Cuenta.Foto,
                        Fecha_Alta = (DateTime)content.Cuenta.Fecha_Alta,
                        Usuario = content.Cuenta.Usuario,
                        Id_Usuario = content.Cuenta.UsuarioId
                    },
                    Fecha_Alta = (DateTime)content.Fecha_Alta
                })
                .ToList();
        }
        public ReadContentDTO GetByAccount(string cuenta)
        {
            
            return _context.TM_CONTENIDO.Where(c => c.Cuenta.Nombre_Cuenta == cuenta)
                .Select(content => new ReadContentDTO
                {
                    Titulo = content.Titulo,
                    Descripcion = content.Descripcion,
                    Media = content.Media,
                    Cuenta = new ReadAccountDTO {
                        Nombre = content.Cuenta.Nombre_Cuenta,
                        Bio = content.Cuenta.Bio,
                        Foto = content.Cuenta.Foto,
                        Fecha_Alta = (DateTime)content.Cuenta.Fecha_Alta,
                        Usuario =  content.Cuenta.Usuario,
                        Id_Usuario = content.Cuenta.UsuarioId
                    },
                    Fecha_Alta = (DateTime)content.Fecha_Alta
                })
                .ToList().FirstOrDefault();
        }

        public ReadContentDTO GetByVisibility(string tv)
        {
            return _context.TM_CONTENIDO.Where(c => c.Visibilidad.Tipo_De_Visibilidad == tv)
                .Select(content => new ReadContentDTO
                {
                    Titulo = content.Titulo,
                    Descripcion = content.Descripcion,
                    Media = content.Media,
                    Cuenta = new ReadAccountDTO
                    {
                        Nombre = content.Cuenta.Nombre_Cuenta,
                        Bio = content.Cuenta.Bio,
                        Foto = content.Cuenta.Foto,
                        Fecha_Alta = (DateTime)content.Cuenta.Fecha_Alta,
                        Usuario = content.Cuenta.Usuario,
                        Id_Usuario = content.Cuenta.UsuarioId
                    },
                    Fecha_Alta = (DateTime)content.Fecha_Alta
                })
                .ToList().FirstOrDefault();
        }

        public ReadContentDTO Get1ByAccountAndDate(string cuenta, int dias)
        {
            return _context.TM_CONTENIDO
                .Where(c => c.Cuenta.Nombre_Cuenta == cuenta &&
                            c.Fecha_Alta >= DateTime.Now.AddDays(-dias))
                .OrderByDescending(c => c.Fecha_Alta)
                .Select(content => new ReadContentDTO
                {
                    Titulo = content.Titulo,
                    Descripcion = content.Descripcion,
                    Media = content.Media,
                    Cuenta = new ReadAccountDTO
                    {
                        Nombre = content.Cuenta.Nombre_Cuenta,
                        Bio = content.Cuenta.Bio,
                        Foto = content.Cuenta.Foto,
                        Fecha_Alta = (DateTime)content.Cuenta.Fecha_Alta,
                        Usuario = content.Cuenta.Usuario,
                        Id_Usuario = content.Cuenta.UsuarioId
                    },
                    Fecha_Alta = (DateTime)content.Fecha_Alta
                })
                .FirstOrDefault();
        }
        public IEnumerable<ReadContentDTO> GetAllByAccountAndDate(string cuenta, int dias)
        {
            return _context.TM_CONTENIDO
                .Where(c => c.Cuenta.Nombre_Cuenta == cuenta &&
                            c.Fecha_Alta >= DateTime.Now.AddDays(-dias))
                .OrderByDescending(c => c.Fecha_Alta)
                .Select(content => new ReadContentDTO
                {
                    Titulo = content.Titulo,
                    Descripcion = content.Descripcion,
                    Media = content.Media,
                    Cuenta = new ReadAccountDTO
                    {
                        Nombre = content.Cuenta.Nombre_Cuenta,
                        Bio = content.Cuenta.Bio,
                        Foto = content.Cuenta.Foto,
                        Fecha_Alta = (DateTime)content.Cuenta.Fecha_Alta,
                        Usuario = content.Cuenta.Usuario,
                        Id_Usuario = content.Cuenta.UsuarioId
                    },
                    Fecha_Alta = (DateTime)content.Fecha_Alta
                })
                .ToList();
        }
        public IEnumerable<ReadContentDTO> GetAllByDate(int dias)
        {
            return _context.TM_CONTENIDO
                .Where(c => c.Fecha_Alta >= DateTime.Now.AddDays(-dias))
                .OrderByDescending(c => c.Fecha_Alta)
                .Select(content => new ReadContentDTO
                {
                    Titulo = content.Titulo,
                    Descripcion = content.Descripcion,
                    Media = content.Media,
                    Cuenta = new ReadAccountDTO
                    {
                        Nombre = content.Cuenta.Nombre_Cuenta,
                        Bio = content.Cuenta.Bio,
                        Foto = content.Cuenta.Foto,
                        Fecha_Alta = (DateTime)content.Cuenta.Fecha_Alta,
                        Usuario = content.Cuenta.Usuario,
                        Id_Usuario = content.Cuenta.UsuarioId
                    },
                    Fecha_Alta = (DateTime)content.Fecha_Alta
                })
                .ToList();
        }

    }

    
}