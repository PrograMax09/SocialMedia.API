using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Usuarios;

namespace SocialMedia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosBusiness _business;
        public UsuariosController(IUsuariosBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            try
            {
                var userList = _business.Get();
                return Ok(userList);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{correo}")]
        public ActionResult GetUser(string correo)
        {
            try
            {
                var user = _business.Get(correo);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
