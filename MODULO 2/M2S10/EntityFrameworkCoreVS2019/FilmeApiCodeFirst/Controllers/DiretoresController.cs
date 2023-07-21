using FilmeApiCodeFirst.Context;
using FilmeApiCodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace diretorApiCodeFirst.Controllers
{
    [Route("api/v{version:apiVersion}/diretores")]
    [ApiController]
    public class DiretoresController : ControllerBase
    {
        private readonly FilmeContext _diretorContext;

        public DiretoresController(FilmeContext context)
        {
            _diretorContext = context;
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _diretorContext.Diretores.ToListAsync().ConfigureAwait(true));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Get(int id)
        {
            var diretor = await _diretorContext.Diretores.FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(true);

            if (diretor is null)
            {
                return NotFound();
            }
            return Ok(diretor);
        }
         
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] Diretor diretor)
        {
            _diretorContext.Diretores.Add(diretor);

            await _diretorContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = diretor.Id }, diretor);

        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Put(int id, [FromBody] Diretor diretor)
        {
            bool existeDiretor = await _diretorContext.Diretores.AnyAsync(x => x.Id == id).ConfigureAwait(true);

            if (!existeDiretor)
            {
                return NotFound();
            }

            _diretorContext.Entry(diretor).State = EntityState.Modified;
            await _diretorContext.SaveChangesAsync();

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(int id)
        {
            var diretor = await _diretorContext.Diretores
                                .FirstOrDefaultAsync(x => x.Id == id)
                                .ConfigureAwait(true);

            if (diretor is null)
            {
                return NotFound();
            }

            _diretorContext.Diretores.Remove(diretor);

            await _diretorContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

