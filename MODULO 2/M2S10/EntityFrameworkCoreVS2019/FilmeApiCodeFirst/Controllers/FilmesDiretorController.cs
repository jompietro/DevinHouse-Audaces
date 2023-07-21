using FilmeApiCodeFirst.Context;
using FilmeApiCodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FilmeApiCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesDiretorController : ControllerBase
    {
        private readonly FilmeContext _context;

        public FilmesDiretorController(FilmeContext context)
        {
            _context = context;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.FilmeDiretores
                            .Include(x => x.Diretor)
                            .Include(x => x.Filme)
                            .ToListAsync());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Get(int id)
        {
            var filmesDiretor = await _context.FilmeDiretores
                            .Include(x => x.Diretor)
                            .Include(x => x.Filme)
                            .FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(true);

            if (filmesDiretor is null)
            {
                return NotFound();
            }
            return Ok(filmesDiretor);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] FilmeDiretor filmesDiretor)
        {
            _context.FilmeDiretores.Add(filmesDiretor);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = filmesDiretor.Id }, filmesDiretor);

        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Put(int id, [FromBody] FilmeDiretor filmeDiretor)
        {
            bool existeFilmeDiretor = await _context.FilmeDiretores
                                                    .AnyAsync(x => x.Id == id).ConfigureAwait(true);

            if (!existeFilmeDiretor)
            {
                return NotFound();
            }

            _context.Entry(filmeDiretor).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(int id)
        {
            var filmeDiretor = await _context.FilmeDiretores
                                .Include(x => x.Filme)
                                .Include(x => x.Diretor)
                                .FirstOrDefaultAsync(x => x.Id == id)
                                .ConfigureAwait(true);

            if (filmeDiretor is null)
            {
                return NotFound();
            }

            _context.FilmeDiretores.Remove(filmeDiretor);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}


