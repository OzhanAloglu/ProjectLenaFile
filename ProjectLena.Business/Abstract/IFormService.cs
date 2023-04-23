using ProjectLena.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.Business.Abstract
{
    public interface IFormService
    {
        List<Form> GetList(string p);

        void FormAdd(Form form);

        Form GetByID(int id);

        void FormDelete(Form form);

        void FormUpdate(Form form);

      

    }
}
