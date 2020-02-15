using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CAMMP.Models;

namespace CAMMP.Data
{
    public class CAMMPContext : DbContext
    {
        public CAMMPContext (DbContextOptions<CAMMPContext> options)
            : base(options)
        {
        }

        public DbSet<CAMMP.Models.Aluno> Aluno { get; set; }
    }
}
