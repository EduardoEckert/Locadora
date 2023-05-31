using Domain.ServiceInterfaces;
using Locadora.Model.Telefones;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    [Route("api/telefone")]
    public class TelefoneController : ControllerBase
    {
        private readonly ITelefoneService _telefoneService;

        public TelefoneController(ITelefoneService TelefoneService)
        {
            _telefoneService = TelefoneService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _telefoneService.GetAll().Select(x => (TelefoneModel?)x);
                return Ok(result);
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                TelefoneModel? result = _telefoneService.GetById(id);
                if (result is null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult PostInsert([FromForm] InsertTelefoneModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _telefoneService.Insert(model);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public IActionResult Update([FromForm] UpdateTelefoneModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _telefoneService.Update(model);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            try
            {
                _telefoneService.Delete(id);

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
