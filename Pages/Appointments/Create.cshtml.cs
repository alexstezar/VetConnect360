using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VetConnect360.Data;
using VetConnect360.Models;

namespace VetConnect360.Pages.Appointments
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
            ViewData["PetID"] = new SelectList(_context.Set<Pet>(), "ID", "Name");
            ViewData["DoctorID"] = new SelectList(_context.Set<Doctor>(), "ID", "DoctorFullName");
            ViewData["ServiceID"] = new SelectList(_context.Set<Service>(), "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Appointment Appointment { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Appointment == null || Appointment == null)
            {
                return Page();
            }

            _context.Appointment.Add(Appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
