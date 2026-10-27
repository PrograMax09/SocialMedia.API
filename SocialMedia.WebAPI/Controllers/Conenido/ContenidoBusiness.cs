using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTO.Cuentas;
using BusinessLogic.DTO.Usuarios;
using Entities.AppContext;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BusinessLogic.Contenido
{
    public class ContenidoBusiness : IContenidoBusiness
    {
        private readonly Context _context;
        public ContenidoBusiness(Context context)
        {
            _context = context;
        }
        public ReadContentDTO CreateContent(CreateContentDTO content)
        {
            if (content == null) 
            { 
                throw new ArgumentNullException(nameof(content)); 
            } 

            if (string.IsNullOrWhiteSpace(content.Titulo) || 
                string.IsNullOrWhiteSpace(content.Cuenta) || 
                string.IsNullOrWhiteSpace(content.Visibilidad)) 
            { 
                throw new ArgumentException( 
                    "Title, account name or visibility is empty."); 
            } 

            var cuenta = _context.TM_CUENTAS 
                .FirstOrDefault(c => c.Nombre_Cuenta == content.Cuenta); 

            if (cuenta == null) 
            { 
                throw new ArgumentException( 
                    "The selected account does not exist."); 
            } 

            var visibilidad = _context.TM_TIPOS_DE_VISIBILIDAD 
                .FirstOrDefault(v => v.Tipo_De_Visibilidad == content.Visibilidad); 

            if (visibilidad == null) 
            { 
                throw new ArgumentException( 
                    "The selected visibility type does not exist."); 
            } 

            var nuevoContenido = new TM_CONTENIDO 

            { 
                Titulo = content.Titulo, 
                Descripcion = content.Descripcion, 
                Media = content.Media, 
                Id_Cuenta = cuenta.Id, 
                Id_Visibilidad = visibilidad.Id, 
                Fecha_Alta = DateTime.Now 
            }; 
            
            _context.TM_CONTENIDO.Add(nuevoContenido); 
            _context.SaveChanges(); 
            
            return new ReadContentDTO 
            { 
                Titulo = nuevoContenido.Titulo,
                Descripcion = nuevoContenido.Descripcion, 
                Media = nuevoContenido.Media, 
                Cuenta = new ReadAccountDTO 
                { 
                    Nombre = cuenta.Nombre_Cuenta, 
                    Bio = cuenta.Bio, 
                    Foto = cuenta.Foto, 
                    Fecha_Alta = cuenta.Fecha_Alta ?? DateTime.Now, 
                    Usuario = cuenta.Usuario, 
                    Id_Usuario = cuenta.UsuarioId 
                }, 
                Fecha_Alta = nuevoContenido.Fecha_Alta ?? DateTime.Now 
            }; 
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