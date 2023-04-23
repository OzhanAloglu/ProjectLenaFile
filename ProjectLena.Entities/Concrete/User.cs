using ProjectLena.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }






        //public ICollection<Form> Forms { get; set; }
    }
}
