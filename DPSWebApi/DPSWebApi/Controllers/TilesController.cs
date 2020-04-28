using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DPSWebApi.Data;
using DPSWebApi.Models;

namespace DPSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TilesController : ControllerBase
    {
        private readonly DPSWebApiContext _context;

        public TilesController(DPSWebApiContext context)
        {
            _context = context;
        }

        // GET: api/Tiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tile>>> GetTile()
        {
            return await _context.Tile.ToListAsync();
        }

        // GET: api/Tiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tile>> GetTile(int id)
        {
            var tile = await _context.Tile.FindAsync(id);

            if (tile == null)
            {
                return NotFound();
            }

            return tile;
        }

        // PUT: api/Tiles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTile(int id, Tile tile)
        {
            if (id != tile.Id)
            {
                return BadRequest();
            }

            _context.Entry(tile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TileExists(id))
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

        // POST: api/Tiles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tile>> PostTile(Tile tile)
        {
            _context.Tile.Add(tile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTile", new { id = tile.Id }, tile);
        }

        // DELETE: api/Tiles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tile>> DeleteTile(int id)
        {
            var tile = await _context.Tile.FindAsync(id);
            if (tile == null)
            {
                return NotFound();
            }

            _context.Tile.Remove(tile);
            await _context.SaveChangesAsync();

            return tile;
        }

        private bool TileExists(int id)
        {
            return _context.Tile.Any(e => e.Id == id);
        }
    }
}
