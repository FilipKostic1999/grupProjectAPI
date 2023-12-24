using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CCC.Models;
using CusCarCom.Models;

namespace CusCarCom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly CCCContext _context;

        public CompaniesController(CCCContext context)
        {
            _context = context;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            // Hämtar alla företag från databasen om det finns några, annars returnerar NotFound-resultat.
            if (_context.Companies == null)
            {
                return NotFound();
            }
            return await _context.Companies.ToListAsync();
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            // Hämtar ett specifikt företag med angivet ID från databasen om det finns, annars returnerar NotFound-resultat.
            if (_context.Companies == null)
            {
                return NotFound();
            }
            var company = await _context.Companies.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        // PUT: api/Companies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            // Uppdaterar ett företag med angivet ID om det existerar, annars returnerar BadRequest om ID:t inte matchar företagets ID.
            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(id))
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

        // POST: api/Companies
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            // Skapar ett nytt företag i databasen om det finns en Company-entitet, annars returnerar Problem-resultat.
            if (_context.Companies == null)
            {
                return Problem("Entity set 'CCCContext.Companies' is null.");
            }
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompany", new { id = company.ID }, company);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            // Tar bort ett företag med angivet ID om det existerar, annars returnerar NotFound-resultat.
            if (_context.Companies == null)
            {
                return NotFound();
            }
            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Kontrollerar om ett företag med givet ID existerar i databasen.
        private bool CompanyExists(int id)
        {
            return (_context.Companies?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
