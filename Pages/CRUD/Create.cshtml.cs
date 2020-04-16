using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Consoli_Ricette.Data;
using Consoli_Ricette.Models;
using System.Security.Claims;


namespace Consoli_Ricette.Pages.CRUD
{
    public class CreateModel : PageModel
    {
        private readonly Consoli_Ricette.Data.Consoli_RicetteContext _context;

        public CreateModel(Consoli_Ricette.Data.Consoli_RicetteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string userid { get; set; }
        public IActionResult OnGet()
        {
            userid = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return Page();
        }

        [BindProperty]
        public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recipe.Add(Recipe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}