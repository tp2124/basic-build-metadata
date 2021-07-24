﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuildMetadata.Models;

namespace BuildMetadata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildsController : ControllerBase
    {
        private readonly BuildContext _context;

        public BuildsController(BuildContext context)
        {
            _context = context;
        }

        // GET: api/Builds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Build>>> GetBuilds()
        {
            return await _context.Builds.ToListAsync();
        }

        // GET: api/Builds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Build>> GetBuild(uint id)
        {
            var build = await _context.Builds.FindAsync(id);

            if (build == null)
            {
                return NotFound();
            }

            return build;
        }

        // PUT: api/Builds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuild(uint id, Build build)
        {
            if (id != build.ChangelistNumber)
            {
                return BadRequest();
            }

            _context.Entry(build).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildExists(id))
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

        // POST: api/Builds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Build>> PostBuild(Build build)
        {
            _context.Builds.Add(build);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBuild", new { id = build.ChangelistNumber }, build);
        }

        // DELETE: api/Builds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBuild(uint id)
        {
            var build = await _context.Builds.FindAsync(id);
            if (build == null)
            {
                return NotFound();
            }

            _context.Builds.Remove(build);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BuildExists(uint id)
        {
            return _context.Builds.Any(e => e.ChangelistNumber == id);
        }
    }
}
