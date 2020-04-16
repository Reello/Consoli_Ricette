using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Consoli_Ricette.Data;
using Consoli_Ricette.Models;
using System.Security.Claims;


namespace Consoli_Ricette.Pages.CRUD
{
    public class DetailsModel : PageModel
    {
        private readonly Consoli_Ricette.Data.Consoli_RicetteContext _context;

        public DetailsModel(Consoli_Ricette.Data.Consoli_RicetteContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }

        [BindProperty]
        public string userid { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            userid = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipe.FirstOrDefaultAsync(m => m.id == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
