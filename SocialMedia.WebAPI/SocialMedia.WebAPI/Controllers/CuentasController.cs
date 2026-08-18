using BusinessLogic.Cuentas;
using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/accounts")]
    public class CuentasController : ControllerBase
    {
        private readonly ICuentasBusiness _business;
        public CuentasController(ICuentasBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        public ActionResult GetAllAccounts()
        {
            try
            {
                var accountList = _business.Get();
                return Ok(accountList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{nombre}")]
        public ActionResult GetAccount(string nombre)
        {
            try
            {
                var account = _business.Get(nombre);
                return Ok(account);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
