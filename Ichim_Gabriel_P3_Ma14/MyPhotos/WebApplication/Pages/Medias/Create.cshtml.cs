﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;
using WebApplication.Data;

namespace WebApplication.Pages.Medias
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication.Data.WebApplicationContext _context;

        public CreateModel(WebApplication.Data.WebApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Medias Medias { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Medias.Add(Medias);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
