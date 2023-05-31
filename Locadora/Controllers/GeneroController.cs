using Domain.ServiceInterfaces;
using Locadora.Model;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    [Route("genero")]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroService _generoService;

        public GeneroController(IGeneroService generoService)
        {
            _generoService = generoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = _generoService.GetAll().Select(x => (GeneroModel?)x);
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
                GeneroModel? result = _generoService.GetById(id);
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
        public IActionResult PostInsert([FromForm] InsertGeneroModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _generoService.Insert(model);
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
        public IActionResult Update([FromForm] UpdateGeneroModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _generoService.Update(model);
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
                _generoService.Delete(id);

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
