using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VetConnect360.Data;
using VetConnect360.Models;

namespace VetConnect360.Pages.Pets
{
    public class DeleteModel : PageModel
    {
        private readonly VetConnect360.Data.VetConnect360Context _context;

        public DeleteModel(VetConnect360.Data.VetConnect360Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Pet Pet { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pet == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet.FirstOrDefaultAsync(m => m.ID == id);

            if (pet == null)
            {
                return NotFound();
            }
            else 
            {
                Pet = pet;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Pet == null)
            {
                return NotFound();
            }
            var pet = await _context.Pet.FindAsync(id);

            if (pet != null)
            {
                Pet = pet;
                _context.Pet.Remove(Pet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
