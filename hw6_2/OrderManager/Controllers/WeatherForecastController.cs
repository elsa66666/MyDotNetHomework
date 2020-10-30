using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagerWeb;
using OrderManagerWeb.Models;

namespace OrderManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderlistsController : ControllerBase
    {
        private readonly OrderManagerContext _context;

        public orderlistsController(OrderManagerContext context)
        {
            _context = context;
        }

        // GET: api/orderlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<orderlist>>> Getorderlists()
        {
            return await _context.orderlists.ToListAsync();
        }

        // GET: api/orderlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<orderlist>> Getorderlist(int id)
        {
            var orderlist = await _context.orderlists.FindAsync(id);

            if (orderlist == null)
            {
                return NotFound();
            }

            return orderlist;
        }

        // PUT: api/orderlists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putorderlist(int id, orderlist orderlist)
        {
            if (id != orderlist.OrderID)
            {
                return BadRequest();
            }

            _context.Entry(orderlist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!orderlistExists(id))
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

        // POST: api/orderlists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<orderlist>> Postorderlist(orderlist orderlist)
        {
            _context.orderlists.Add(orderlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Getorderlist), new { id = orderlist.OrderID }, orderlist);
        }

        // DELETE: api/orderlists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<orderlist>> Deleteorderlist(int id)
        {
            var orderlist = await _context.orderlists.FindAsync(id);
            if (orderlist == null)
            {
                return NotFound();
            }

            _context.orderlists.Remove(orderlist);
            await _context.SaveChangesAsync();

            return orderlist;
        }

        private bool orderlistExists(int id)
        {
            return _context.orderlists.Any(e => e.OrderID == id);
        }
    }
}
