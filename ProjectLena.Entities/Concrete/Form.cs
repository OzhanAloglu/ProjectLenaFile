using ProjectLena.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.Entities.Concrete
{
    public class Form : IEntity
    {
        [Key]
        public int FormId { get; set; }

        public string FormName { get; set; }

        public string Description { get; set; }

        public DateTime CreateAt { get; set; }


        public string Name { get; set; }

        public string Surname { get; set; }

        public int? Age { get; set; }





    }
}
