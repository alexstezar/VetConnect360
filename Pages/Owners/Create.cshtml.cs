using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VetConnect360.Data;
using VetConnect360.Models;

namespace VetConnect360.Pages.Owners
{
    public class CreateModel : PageModel
    {
        private readonly VetConnect360.Data.VetConnect360Context _context;

        public CreateModel(VetConnect360.Data.VetConnect360Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Owner Owner { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Owner == null || Owner == null)
            {
                return Page();
            }

            _context.Owner.Add(Owner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
