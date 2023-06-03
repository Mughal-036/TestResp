using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud.Model;

namespace Crud.Data
{
    public class CrudContext : DbContext
    {
        public CrudContext (DbContextOptions<CrudContext> options)
            : base(options)
        {
        }

        public DbSet<Crud.Model.Resturant> Resturant { get; set; }
    }
}
