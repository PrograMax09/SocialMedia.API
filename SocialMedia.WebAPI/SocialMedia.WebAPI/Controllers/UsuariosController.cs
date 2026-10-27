using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Usuarios;
using BusinessLogic.DTO.Usuarios;

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

        [HttpPost] 
        public ActionResult Create([FromBody] CreateUserDTO createUser) 
        { 
            try 
            { 
                var newUser = _business.CreateUser(createUser); 
                return CreatedAtAction(
                    nameof(GetUser), 
                    new { correo = newUser.Correo }, 
                    newUser
                );
            } 
            catch (ArgumentException ex) 
            { 
                return BadRequest(ex.Message); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    error = ex.Message,
                    innerError = ex.InnerException?.Message
                });
            }
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
