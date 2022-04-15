using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        public int Marks { get; set; }
        public int Semester_Id { get; set; }
        public short Status { get; set; }
        public int Academicyear_Id { get; set; }
        public int Class_Id { get; set; }
        public int User_Id { get; set; }
        public int Exams_Id { get; set; }

        public virtual Academicyear Academicyear { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Exams Exams { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual User User { get; set; }
    }
}