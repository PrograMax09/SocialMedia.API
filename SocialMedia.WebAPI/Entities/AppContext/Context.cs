using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entities.AppContext
{
    public class Context : DbContext
    {
        public DbSet<TM_CUENTAS> TM_CUENTAS { get; set; }
        public DbSet<TM_CONTENIDO> TM_CONTENIDO { get; set; }
        public DbSet<TM_USUARIOS> TM_USUARIOS { get; set; }
        public DbSet<TM_TIPOS_DE_VISIBILIDAD>  TM_TIPOS_DE_VISIBILIDAD {get; set; }
        public DbSet<TR_CONTENIDO_CUENTAS> TR_CONTENIDO_CUENTAS { get; set; }
        public DbSet<TR_CUENTAS_SEGUIDORES> TR_CUENTAS_SEGUIDORES { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                var server = "localhost";
                var user = "sa";
                var catalog = "SocialMediaDB";
                var password = "SocialMedia321!";

                var stringConnection = $"Server=tcp:{server},1433;" + $" Database={catalog};" +
                        $" User Id={user}; Password={password}; " +
                        " TrustServerCertificate=True; Connection Timeout=120;";

                optionsBuilder.UseSqlServer(stringConnection);

            }
            catch (Exception ex)
            {
                var m = ex.Message;
                throw;
            }
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            #region UserDefaultValues

            var user1 = new TM_USUARIOS()
            {
                Id = 1,
                Correo = "ejemplo@gmail.com",
                Contrasena = "123321",
                Descripcion = "Hola mundo",
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };

            var user2 = new TM_USUARIOS()
            {
                Id = 2,
                Correo = "abc@gmail.com",
                Contrasena = "Contrasena",
                Descripcion = "cba",
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };

            var user3 = new TM_USUARIOS()
            {
                Id = 3,
                Correo = "hello@gmail.com",
                Contrasena = "Hi!",
                Descripcion = "soy usuario num.3",
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };


            var user4 = new TM_USUARIOS()
            {
                Id = 4,
                Correo = "user@gmail.com",
                Contrasena = "######",
                Descripcion = "##### ### ####",
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };

            #endregion

            #region CuentasDefaultValues

            var account1 = new TM_CUENTAS()
            {
                Id = 1,
                Nombre_Cuenta = "Juan",
                Bio = "Cuenta n.1",
                Foto = "foto1.png",
                Contrasena = "IAmJuan",
                UsuarioId = user1.Id,
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };


            var account2 = new TM_CUENTAS()
            {
                Id = 2,
                Nombre_Cuenta = "Pepe",
                Bio = "Bla bla bla",
                Foto = "foto2.png",
                Contrasena = "pepe",
                UsuarioId = user2.Id,
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };

            var account3 = new TM_CUENTAS()
            {
                Id = 3,
                Nombre_Cuenta = "Trevor",
                Bio = ".",
                Foto = "foto3.png",
                Contrasena = ".",
                UsuarioId = user3.Id,
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };

            var account4 = new TM_CUENTAS()
            {
                Id = 4,
                Nombre_Cuenta = "William",
                Bio = "Afton",
                Foto = "foto4.png",
                Contrasena = "Help",
                UsuarioId = user4.Id,
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };

            var account5 = new TM_CUENTAS()
            {
                Id = 5,
                Nombre_Cuenta = "Mimic",
                Bio = "The Mimic",
                Foto = "foto5.png",
                Contrasena = "...",
                UsuarioId = user4.Id,
                Fecha_Alta = DateTime.Now,
                Fecha_Baja = null,
                Fecha_Mod = null
            };

            #endregion

            #region Tipos_De_VisibilidadDefaultValues

            var visibilidad1 = new TM_TIPOS_DE_VISIBILIDAD()
            {
                Id = 1,
                Tipo_De_Visibilidad = "Publico",
                Fecha_Alta = DateTime.Now
            };

            var visibilidad2 = new TM_TIPOS_DE_VISIBILIDAD()
            {
                Id = 2,
                Tipo_De_Visibilidad = "Privado",
                Fecha_Alta = DateTime.Now
            };

            var visibilidad3 = new TM_TIPOS_DE_VISIBILIDAD()
            {
                Id = 3,
                Tipo_De_Visibilidad = "Oculto",
                Fecha_Alta = DateTime.Now
            };

            #endregion

            #region ContenidoDefaultValues

            var contenido1 = new TM_CONTENIDO()
            {
                Id = 1,
                Titulo = "Hello.",
                Descripcion = "descripcion descripcion descripcion",
                Media = "foto6.png",
                Id_Visibilidad = visibilidad2.Id,
                Id_Cuenta = account2.Id,
                Fecha_Alta = DateTime.Now
            };

            var contenido2 = new TM_CONTENIDO()
            {
                Id = 2,
                Titulo = "Beach",
                Descripcion = "Self explanatory",
                Media = "foto7.png",
                Id_Visibilidad = visibilidad1.Id,
                Id_Cuenta = account3.Id,
                Fecha_Alta = DateTime.Now
            };

            var contenido3 = new TM_CONTENIDO()
            {
                Id = 3,
                Titulo = "Help",
                Descripcion = "Can you read this?",
                Media = "foto8.png",
                Id_Visibilidad = visibilidad3.Id,
                Id_Cuenta = account4.Id,
                Fecha_Alta = DateTime.Now
            };

            var contenido4 = new TM_CONTENIDO()
            {
                Id = 4,
                Titulo = "Forest",
                Descripcion = "Doesn't need explaining",
                Media = "foto8.png",
                Id_Visibilidad = visibilidad1.Id,
                Id_Cuenta = account3.Id,
                Fecha_Alta = DateTime.Now
            };

            #endregion

            #region Contenido_CuentasDefaultValues

            var cc1 = new TR_CONTENIDO_CUENTAS()
            {
                Id = 1,
                Id_Contenido = contenido1.Id,
                Id_Cuenta = account2.Id,
                Fecha_Alta = DateTime.Now
            };

            var cc2 = new TR_CONTENIDO_CUENTAS()
            {
                Id = 2,
                Id_Contenido = contenido2.Id,
                Id_Cuenta = account3.Id,
                Fecha_Alta = DateTime.Now
            };

            var cc3 = new TR_CONTENIDO_CUENTAS()
            {
                Id = 3,
                Id_Contenido = contenido3.Id,
                Id_Cuenta = account4.Id,
                Fecha_Alta = DateTime.Now
            };

            var cc4 = new TR_CONTENIDO_CUENTAS()
            {
                Id = 4,
                Id_Contenido = contenido4.Id,
                Id_Cuenta = account3.Id,
                Fecha_Alta = DateTime.Now
            };

            #endregion

            #region Cuentas_SeguidoresDefaultValues

            var cs1 = new TR_CUENTAS_SEGUIDORES()
            {
                Id = 1,
                Id_Cuenta = account1.Id,
                Id_Cuenta_Seguida = account3.Id,
                Fecha_Alta = DateTime.Now
            };

            var cs2 = new TR_CUENTAS_SEGUIDORES()
            {
                Id = 2,
                Id_Cuenta = account2.Id,
                Id_Cuenta_Seguida = account3.Id,
                Fecha_Alta = DateTime.Now
            };

            var cs3 = new TR_CUENTAS_SEGUIDORES()
            {
                Id = 3,
                Id_Cuenta = account5.Id,
                Id_Cuenta_Seguida = account4.Id,
                Fecha_Alta = DateTime.Now
            };

            #endregion

            #region Seed_Data
            
            modelbuilder.Entity<TM_USUARIOS>().HasData(new TM_USUARIOS[] {user1, user2, user3, user4});

            modelbuilder.Entity<TM_CUENTAS>().HasData(new TM_CUENTAS[] { account1, account2, account3, account4, account5});

            modelbuilder.Entity<TM_TIPOS_DE_VISIBILIDAD>().HasData(new TM_TIPOS_DE_VISIBILIDAD[] { visibilidad1, visibilidad2, visibilidad3 });

            modelbuilder.Entity<TM_CONTENIDO>().HasData(new TM_CONTENIDO[] { contenido1, contenido2, contenido3, contenido4 });

            modelbuilder.Entity<TR_CONTENIDO_CUENTAS>().HasData(new TR_CONTENIDO_CUENTAS[] { cc1, cc2, cc3 });

            modelbuilder.Entity<TR_CUENTAS_SEGUIDORES>().HasData(new TR_CUENTAS_SEGUIDORES[] { cs1, cs2, cs3 });

            #endregion

        }
    }
}
