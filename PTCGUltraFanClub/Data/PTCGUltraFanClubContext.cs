using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PTCGUltraFanClub.Models
{
    public class PTCGUltraFanClubContext : DbContext
    {
        public PTCGUltraFanClubContext(DbContextOptions<PTCGUltraFanClubContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDeckChoice> UserDeckChoices { get; set; }
    }
}
