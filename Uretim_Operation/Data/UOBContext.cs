using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uretim_Operation.Models;

namespace Uretim_Operation.Data
{
    public class UOBContext: DbContext
    {
        public UOBContext(DbContextOptions<UOBContext> options)
               : base(options)
        {
        }

        public DbSet<Notifications> Notifications { get; set; }
    }
}
