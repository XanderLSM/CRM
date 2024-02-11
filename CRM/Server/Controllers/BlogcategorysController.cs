using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRM.Server.Data;
using CRM.Shared.Domain;
using CRM.Server.IRepository;

namespace CRM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogcategorysController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public BlogcategorysController(ApplicationDbContext context)
        public BlogcategorysController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Blogcategorys
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Blogcategory>>> GetBlogcategorys()
        public async Task<IActionResult> GetBlogcategorys()
        {
            //if (_context.Blogcategorys == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Blogcategorys.ToListAsync();
            var blogcategorys = await _unitOfWork.Blogcategorys.GetAll();
            return Ok(blogcategorys);

        }

        // GET: api/Blogcategorys/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Blogcategory>> GetBlogcategory(int id)
        public async Task<IActionResult> GetBlogcategory(int id)
        {
            var blogcategory = await _unitOfWork.Blogcategorys.Get(q => q.Id == id);

            if (blogcategory == null)
            {
                return NotFound();
            }

            return Ok(blogcategory);

            //if (_context.Blogcategorys == null)
            //{
            //    return NotFound();
            //}
            //  var blogcategory = await _context.Blogcategorys.FindAsync(id);

            //  if (blogcategory == null)
            //  {
            //      return NotFound();
            //  }

            //  return blogcategory;
        }

        // PUT: api/Blogcategorys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlogcategory(int id, Blogcategory blogcategory)
        {
            if (id != blogcategory.Id)
            {
                return BadRequest();
            }

            //_context.Entry(blogcategory).State = EntityState.Modified;
            _unitOfWork.Blogcategorys.Update(blogcategory);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BlogcategoryExists(id))
                if (!await BlogcategoryExists(id))
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

        // POST: api/Blogcategorys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Blogcategory>> PostBlogcategory(Blogcategory blogcategory)
        {
            await _unitOfWork.Blogcategorys.Insert(blogcategory);
            await _unitOfWork.Save(HttpContext);
            //if (_context.Blogcategorys == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Blogcategorys'  is null.");
            //}
            //  _context.Blogcategorys.Add(blogcategory);
            //  await _context.SaveChangesAsync();

            return CreatedAtAction("GetBlogcategory", new { id = blogcategory.Id }, blogcategory);
        }

        // DELETE: api/Blogcategorys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogcategory(int id)
        {
            var blogcategory = await _unitOfWork.Blogcategorys.Get(q => q.Id == id);
            //if (_context.Blogcategorys == null)
            //{
            //    return NotFound();
            //}
            //var blogcategory = await _context.Blogcategorys.FindAsync(id);
            if (blogcategory == null)
            {
                return NotFound();
            }

            //_context.Blogcategorys.Remove(blogcategory);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Blogcategorys.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool BlogcategoryExists(int id)
        private async Task<bool> BlogcategoryExists(int id)
        {
            var blogcategory = await _unitOfWork.Blogcategorys.Get(q => q.Id == id);
            return blogcategory != null;
            //return (_context.Blogcategorys?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
