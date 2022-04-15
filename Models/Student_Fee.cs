using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class Student_Fee
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Semester_Id { get; set; }
        public decimal Fee { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual User User { get; set; }
    }
}