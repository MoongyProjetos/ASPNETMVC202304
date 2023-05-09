using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IntroBlazor.Data.Model;

namespace IntroBlazor.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudanteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstudanteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Estudante
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudante>>> GetEstudantes()
        {
          if (_context.Estudantes == null)
          {
              return NotFound();
          }
            return await _context.Estudantes.ToListAsync();
        }

        // GET: api/Estudante/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudante>> GetEstudante(int id)
        {
          if (_context.Estudantes == null)
          {
              return NotFound();
          }
            var estudante = await _context.Estudantes.FindAsync(id);

            if (estudante == null)
            {
                return NotFound();
            }

            return estudante;
        }

        // PUT: api/Estudante/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstudante(int id, Estudante estudante)
        {
            if (id != estudante.EstudanteId)
            {
                return BadRequest();
            }

            _context.Entry(estudante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudanteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Estudante
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Estudante>> PostEstudante(Estudante estudante)
        {
          if (_context.Estudantes == null)
          {
              return Problem("Entity set 'AppDbContext.Estudantes'  is null.");
          }
            _context.Estudantes.Add(estudante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstudante", new { id = estudante.EstudanteId }, estudante);
        }

        // DELETE: api/Estudante/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudante(int id)
        {
            if (_context.Estudantes == null)
            {
                return NotFound();
            }
            var estudante = await _context.Estudantes.FindAsync(id);
            if (estudante == null)
            {
                return NotFound();
            }

            _context.Estudantes.Remove(estudante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstudanteExists(int id)
        {
            return (_context.Estudantes?.Any(e => e.EstudanteId == id)).GetValueOrDefault();
        }
    }
}
