using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VetConnect360.Data;
using VetConnect360.Models;

namespace VetConnect360.Pages.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly VetConnect360.Data.VetConnect360Context _context;

        public IndexModel(VetConnect360.Data.VetConnect360Context context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointment
                .Include(b => b.Pet)
                .Include(b => b.Doctor)
                .Include(b => b.Service)
                .ToListAsync();
        }
    }
}
