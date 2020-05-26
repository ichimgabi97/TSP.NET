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
    public class IndexModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public IndexModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public IList<Model_App> Model_App { get;set; }

        public async Task OnGetAsync()
        {
            Model_App = await _context.Model_App.ToListAsync();
        }
    }
}
