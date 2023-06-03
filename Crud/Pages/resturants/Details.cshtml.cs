using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Model;

namespace Crud.Pages.resturants
{
    public class DetailsModel : PageModel
    {
        private readonly Crud.Data.CrudContext _context;

        public DetailsModel(Crud.Data.CrudContext context)
        {
            _context = context;
        }

        public Resturant Resturant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Resturant = await _context.Resturant.FirstOrDefaultAsync(m => m.Id == id);

            if (Resturant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
