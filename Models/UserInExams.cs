using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class UserInExams
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Exams_Id { get; set; }

        public virtual Exams Exams { get; set; }
        public virtual User User { get; set; }
    }
}