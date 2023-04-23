using ProjectLena.DataAccess.Abstract;
using ProjectLena.DataAccess.Concrete.Repositories;
using ProjectLena.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.DataAccess.EntityFramework
{
    public class EfUserDal:GenericRepository<User>,IUserDal
    {
    }
}
