using ProjectLena.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.DataAccess.Concrete
{
    public class Context : DbContext
    {
       
        public DbSet<User> Users { get; set; }

        public DbSet<Form> Forms { get; set; }

        

    }
}
