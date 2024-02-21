using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InfiniteDraws_Creations.Models;

namespace InfiniteDraws_Creations.Data
{
    public class InfiniteDraws_CreationsContext : DbContext
    {
        public InfiniteDraws_CreationsContext (DbContextOptions<InfiniteDraws_CreationsContext> options)
            : base(options)
        {
        }

        public DbSet<InfiniteDraws_Creations.Models.Drawer> Drawer { get; set; } = default!;
    }
}
