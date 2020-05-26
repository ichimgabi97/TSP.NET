using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using WebApplication.Data;

namespace WebApplication.Pages.Medias
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication.Data.WebApplicationContext _context;

        public DetailsModel(WebApplication.Data.WebApplicationContext context)
        {
            _context = context;
        }

        public Medias Medias { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medias = await _context.Medias.FirstOrDefaultAsync(m => m.ID == id);

            if (Medias == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
