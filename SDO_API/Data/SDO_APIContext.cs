using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SDO_API.Model;

namespace SDO_API.Models
{
    public class SDO_APIContext : DbContext
    {
        public SDO_APIContext (DbContextOptions<SDO_APIContext> options)
            : base(options)
        {
        }

        public DbSet<SDO_API.Model.Class> Class { get; set; }
    }
}
