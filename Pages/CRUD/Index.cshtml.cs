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
    public class IndexModel : PageModel
    {
        private readonly Consoli_Ricette.Data.Consoli_RicetteContext _context;

        public IndexModel(Consoli_Ricette.Data.Consoli_RicetteContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        [BindProperty]
        public string userid { get; set; }

        public async Task OnGetAsync()
        {
            if(User.Identity.IsAuthenticated)
                userid = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Recipe = await _context.Recipe.ToListAsync();
        }
    }
}
