using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ENTITYcodefirst23.Models;

namespace ENTITYcodefirst23.Data
{
    public class ENTITYcodefirst23Context : DbContext
    {
        public ENTITYcodefirst23Context (DbContextOptions<ENTITYcodefirst23Context> options)
            : base(options)
        {
        }

        public DbSet<ENTITYcodefirst23.Models.Student> Student { get; set; } = default!;
    }
}
