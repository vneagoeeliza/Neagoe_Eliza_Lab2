using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Neagoe_Eliza_Lab2.Data;
using Neagoe_Eliza_Lab2.Models;

namespace Neagoe_Eliza_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Neagoe_Eliza_Lab2.Data.Neagoe_Eliza_Lab2Context _context;

        public CreateModel(Neagoe_Eliza_Lab2.Data.Neagoe_Eliza_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
