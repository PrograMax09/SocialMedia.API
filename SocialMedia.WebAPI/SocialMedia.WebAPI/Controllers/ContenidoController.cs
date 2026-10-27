using System;
using BusinessLogic.Contenido;
using BusinessLogic.DTO.Cuentas;
using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/content")]
    public class ContenidoController : ControllerBase
    {
        private readonly IContenidoBusiness _business;
        public ContenidoController(IContenidoBusiness business)
        {
            _business = business;
        }

        
        [HttpPost]
        public ActionResult Create([FromBody] CreateContentDTO createContent)
        {
            try
            {
                var content = _business.CreateContent(createContent);
                return StatusCode(201, content);
            }
            catch (Exception)
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }


        [HttpGet]
        public ActionResult Get() {
            try
            {
                var content = _business.Get();
                return Ok(content);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{mode}")]
        public ActionResult GetOrdered(string mode)
        {
            try
            {
                var content = _business.GetOrdered(mode);
                return Ok(content);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("visibility/{visibility}")]
        public ActionResult GetByVisibility(string visibility)
        {
            try
            {
                var content = _business.GetByVisibility(visibility);
                return Ok(content);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("account/{cuenta}")]
        public ActionResult Get1ByAccountAndDate(string cuenta, int dias)
        {
            try
            {
                var content = _business.Get1ByAccountAndDate(cuenta, dias);
                return Ok(content);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("account/all/{cuenta}/")]
        public ActionResult GetAllByAccountAndDate(string cuenta, int dias)
        {
            try
            {
                var content = _business.GetAllByAccountAndDate(cuenta, dias);
                return Ok(content);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("date/{dias}")]
        public ActionResult GetAllByDate(int dias)
        {
            try
            {
                var content = _business.GetAllByDate(dias);
                return Ok(content);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
