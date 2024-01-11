using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using recordetur_api.Context;
using recordetur_api.Models;

namespace recordetur_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViagensController : ControllerBase
    {
        private readonly DataContext _context;

        public ViagensController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Viagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Viagens>>> GetViagens()
        {
            return await _context.Viagens.ToListAsync();
        }

        // GET: api/Viagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Viagens>> GetViagens(int id)
        {
            var viagens = await _context.Viagens.FindAsync(id);

            if (viagens == null)
            {
                return NotFound();
            }

            return viagens;
        }

        // PUT: api/Viagens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViagens(int id, Viagens viagens)
        {
            if (id != viagens.ViagemId)
            {
                return BadRequest();
            }

            _context.Entry(viagens).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViagensExists(id))
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

        // POST: api/Viagens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Viagens>> PostViagens(Viagens viagens)
        {
            _context.Viagens.Add(viagens);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViagens", new { id = viagens.ViagemId }, viagens);
        }

        // DELETE: api/Viagens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteViagens(int id)
        {
            var viagens = await _context.Viagens.FindAsync(id);
            if (viagens == null)
            {
                return NotFound();
            }

            _context.Viagens.Remove(viagens);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ViagensExists(int id)
        {
            return _context.Viagens.Any(e => e.ViagemId == id);
        }
    }
}
