using Domain.ServiceInterfaces;
using Locadora.Model;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    [Route("pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _pessoaService.GetAll().Select(x => (PessoaModel?)x);
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
                PessoaModel? result = _pessoaService.GetById(id);
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
        public IActionResult PostInsert([FromForm] InsertPessoaModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _pessoaService.Insert(model);
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
        public IActionResult Update([FromForm] UpdatePessoaModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _pessoaService.Update(model);
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
                _pessoaService.Delete(id);

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
