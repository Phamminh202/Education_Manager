using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class Academicyear
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<UserInAcademicyear> UserInAcademicyears { get; set; }
    }
}