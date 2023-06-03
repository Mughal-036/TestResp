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
    public class IndexModel : PageModel
    {
        private readonly Crud.Data.CrudContext _context;

        public IndexModel(Crud.Data.CrudContext context)
        {
            _context = context;
        }

        public IList<Resturant> Resturant { get;set; }

        public async Task OnGetAsync()
        {
            Resturant = await _context.Resturant.ToListAsync();
        }
    }
}
