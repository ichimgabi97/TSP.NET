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
    public class IndexModel : PageModel
    {
        private readonly WebApplication.Data.WebApplicationContext _context;

        public IndexModel(WebApplication.Data.WebApplicationContext context)
        {
            _context = context;
        }

        public IList<Medias> Medias { get;set; }

        public async Task OnGetAsync()
        {
            Medias = await _context.Medias.ToListAsync();
        }
    }
}
