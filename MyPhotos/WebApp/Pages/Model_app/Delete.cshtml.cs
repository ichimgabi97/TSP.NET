using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using WebApp.Data;

namespace WebApp.Pages.Model_app
{
    public class DeleteModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public DeleteModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Model_App Model_App { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Model_App = await _context.Model_App.FirstOrDefaultAsync(m => m.ID == id);

            if (Model_App == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Model_App = await _context.Model_App.FindAsync(id);

            if (Model_App != null)
            {
                _context.Model_App.Remove(Model_App);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
