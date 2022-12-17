using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Neagoe_Eliza_Lab2.Data;
using Neagoe_Eliza_Lab2.Models;

namespace Neagoe_Eliza_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Neagoe_Eliza_Lab2.Data.Neagoe_Eliza_Lab2Context _context;

        public DetailsModel(Neagoe_Eliza_Lab2.Data.Neagoe_Eliza_Lab2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing
                .Include(i => i.Member)
                .Include(i => i.Book)
                .ThenInclude(j => j.Author)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (borrowing == null)
            {
                return NotFound();
            }
            Borrowing = borrowing;
         
            return Page();
        }
    }
}
