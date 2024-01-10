using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VetConnect360.Data;
using VetConnect360.Models;

namespace VetConnect360.Pages.Owners
{
    public class DetailsModel : PageModel
    {
        private readonly VetConnect360.Data.VetConnect360Context _context;

        public DetailsModel(VetConnect360.Data.VetConnect360Context context)
        {
            _context = context;
        }

      public Owner Owner { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Owner == null)
            {
                return NotFound();
            }

            var owner = await _context.Owner.FirstOrDefaultAsync(m => m.ID == id);
            if (owner == null)
            {
                return NotFound();
            }
            else 
            {
                Owner = owner;
            }
            return Page();
        }
    }
}
