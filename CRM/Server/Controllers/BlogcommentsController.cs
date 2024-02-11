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
    public class BlogcommentsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public BlogcommentsController(ApplicationDbContext context)
        public BlogcommentsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Blogcomments
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Blogcomment>>> GetBlogcomments()
        public async Task<IActionResult> GetBlogcomments()
        {
            //if (_context.Blogcomments == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Blogcomments.ToListAsync();
            var blogcomments = await _unitOfWork.Blogcomments.GetAll();
            return Ok(blogcomments);

        }

        // GET: api/Blogcomments/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Blogcomment>> GetBlogcomment(int id)
        public async Task<IActionResult> GetBlogcomment(int id)
        {
            var blogcomment = await _unitOfWork.Blogcomments.Get(q => q.Id == id);

            if (blogcomment == null)
            {
                return NotFound();
            }

            return Ok(blogcomment);

            //if (_context.Blogcomments == null)
            //{
            //    return NotFound();
            //}
            //  var blogcomment = await _context.Blogcomments.FindAsync(id);

            //  if (blogcomment == null)
            //  {
            //      return NotFound();
            //  }

            //  return blogcomment;
        }

        // PUT: api/Blogcomments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlogcomment(int id, Blogcomment blogcomment)
        {
            if (id != blogcomment.Id)
            {
                return BadRequest();
            }

            //_context.Entry(blogcomment).State = EntityState.Modified;
            _unitOfWork.Blogcomments.Update(blogcomment);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BlogcommentExists(id))
                if (!await BlogcommentExists(id))
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

        // POST: api/Blogcomments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Blogcomment>> PostBlogcomment(Blogcomment blogcomment)
        {
            await _unitOfWork.Blogcomments.Insert(blogcomment);
            await _unitOfWork.Save(HttpContext);
            //if (_context.Blogcomments == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Blogcomments'  is null.");
            //}
            //  _context.Blogcomments.Add(blogcomment);
            //  await _context.SaveChangesAsync();

            return CreatedAtAction("GetBlogcomment", new { id = blogcomment.Id }, blogcomment);
        }

        // DELETE: api/Blogcomments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlogcomment(int id)
        {
            var blogcomment = await _unitOfWork.Blogcomments.Get(q => q.Id == id);
            //if (_context.Blogcomments == null)
            //{
            //    return NotFound();
            //}
            //var blogcomment = await _context.Blogcomments.FindAsync(id);
            if (blogcomment == null)
            {
                return NotFound();
            }

            //_context.Blogcomments.Remove(blogcomment);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Blogcomments.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool BlogcommentExists(int id)
        private async Task<bool> BlogcommentExists(int id)
        {
            var blogcomment = await _unitOfWork.Blogcomments.Get(q => q.Id == id);
            return blogcomment != null;
            //return (_context.Blogcomments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
