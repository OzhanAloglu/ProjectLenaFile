using ProjectLena.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.Business.Abstract
{
    public interface IUserService
    {
        void AddUser(User user);
    }
}
