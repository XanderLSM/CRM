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
    public class BlogpostsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public BlogpostsController(ApplicationDbContext context)
        public BlogpostsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Blogposts
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Blogpost>>> GetBlogposts()
        public async Task<IActionResult> GetBlogposts()
        {
            //if (_context.Blogposts == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Blogposts.ToListAsync();
            var blogposts = await _unitOfWork.Blogposts.GetAll();
            return Ok(blogposts);

        }

        // GET: api/Blogposts/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Blogpost>> GetBlogpost(int id)
        public async Task<IActionResult> GetBlogpost(int id)
        {
            var blogpost = await _unitOfWork.Blogposts.Get(q => q.Id == id);

            if (blogpost == null)
            {
                return NotFound();
            }

            return Ok(blogpost);

            //if (_context.Blogposts == null)
            //{
            //    return NotFound();
            //}
            //  var blogpost = await _context.Blogposts.FindAsync(id);

            //  if (blogpost == null)
            //  {
            //      return NotFound();
            //  }

            //  return blogpost;
        }

        // PUT: api/Blogposts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlogpost(int id, Blogpost blogpost)
        {
            if (id != blogpost.Id)
            {
                return BadRequest();
            }

            //_context.Entry(blogpost).State = EntityState.Modified;
            _unitOfWork.Blogposts.Update(blogpost);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BlogpostExists(id))
                if (!await BlogpostExists(id))
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

        // POST: api/Blogposts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Blogpost>> PostBlogpost(Blogpost blogpost)
        {
            await _unitOfWork.Blogposts.Insert(blogpost);
            await _unitOfWork.Save(HttpContext);
            //if (_context.Blogposts == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Blogposts'  is null.");
            //}
            //  _context.Blogposts.Add(blogpost);
            //  await _context.SaveChangesAsync();

            return CreatedAtAction("GetBlogpost", new { id = blogpost.Id }, blogpost);
        }

        // DELETE: api/Blogposts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogpost(int id)
        {
            var blogpost = await _unitOfWork.Blogposts.Get(q => q.Id == id);
            //if (_context.Blogposts == null)
            //{
            //    return NotFound();
            //}
            //var blogpost = await _context.Blogposts.FindAsync(id);
            if (blogpost == null)
            {
                return NotFound();
            }

            //_context.Blogposts.Remove(blogpost);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Blogposts.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool BlogpostExists(int id)
        private async Task<bool> BlogpostExists(int id)
        {
            var blogpost = await _unitOfWork.Blogposts.Get(q => q.Id == id);
            return blogpost != null;
            //return (_context.Blogposts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
