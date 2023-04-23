using ProjectLena.Business.Abstract;
using ProjectLena.DataAccess.Abstract;
using ProjectLena.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            _userDal.Insert(user);
        }
    }
}
