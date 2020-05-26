using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using WebApplication.Data;

namespace WebApplication.Pages.Medias
{
    public class EditModel : PageModel
    {
        private readonly WebApplication.Data.WebApplicationContext _context;

        public EditModel(WebApplication.Data.WebApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Medias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MediasExists(Medias.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MediasExists(int id)
        {
            return _context.Medias.Any(e => e.ID == id);
        }
    }
}
