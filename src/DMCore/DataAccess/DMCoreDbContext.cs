using DMCore.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMCore.DataAccess
{
    public class DMCoreDbContext:DbContext
    {
        public DMCoreDbContext()
        {

        }

        public DbSet<AuthUser> AuthUsers { get; set; }
    }
}
