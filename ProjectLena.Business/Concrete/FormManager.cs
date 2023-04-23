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
    public class FormManager : IFormService
    {
        IFormDal _formDal;

        public FormManager(IFormDal formDal)
        {
            _formDal = formDal;
           
        }

        public void FormAdd(Form form)
        {
          
            _formDal.Insert(form);

        }

        public void FormDelete(Form form)
        {
            _formDal.Delete(form);
        }

        public void FormUpdate(Form form)
        {
            _formDal.Update(form);
        }

        public Form GetByID(int id)
        {
            return _formDal.Get(x => x.FormId == id);
        }

        public List<Form> GetList(string p)
        {

            return _formDal.GetAll();

        }
    }
}
