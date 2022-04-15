using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class UserInAcademicyear
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Academicyear_Id { get; set; }

        public virtual Academicyear Academicyear { get; set; }
        public virtual User User { get; set; }
    }
}