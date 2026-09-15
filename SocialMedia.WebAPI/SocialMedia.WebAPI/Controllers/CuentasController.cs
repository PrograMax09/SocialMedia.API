using BusinessLogic.Cuentas;
using BusinessLogic.DTO.Cuentas;
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

        [HttpPost]
        public ActionResult Create([FromBody] CreateAccountDTO createAccount)
        {
            try
            {
                var accountList = _business.CreateAccount(createAccount);
                return Ok(accountList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
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
