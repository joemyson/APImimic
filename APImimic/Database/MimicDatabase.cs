using APImimic.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APImimic.Database
{
    public class MimicDatabase : DbContext
    {
        public MimicDatabase(DbContextOptions<MimicDatabase> options) : base(options)
        {

        }

        public DbSet<PalavraModel> Palavras { get; set; }

    }
}
