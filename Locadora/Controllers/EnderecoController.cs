using Domain.ServiceInterfaces;
using Locadora.Model.Enderecos;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    [Route("api/endereco")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService EnderecoService)
        {
            _enderecoService = EnderecoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _enderecoService.GetAll().Select(x => (EnderecoModel?)x);
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
                EnderecoModel? result = _enderecoService.GetById(id);
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
        public IActionResult PostInsert([FromForm] InsertEnderecoModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _enderecoService.Insert(model);
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
        public IActionResult Update([FromForm] UpdateEnderecoModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _enderecoService.Update(model);
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
                _enderecoService.Delete(id);

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
