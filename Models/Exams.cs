using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class Exams
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Classroom { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime Create_Date { get; set; }
        public int Course_Id { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<UserInExams> UserInExams { get; set; }
    }
}