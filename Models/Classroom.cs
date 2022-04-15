using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class Classroom
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Classname { get; set; }
        public int Qty { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        public virtual ICollection<UserInClassroom> UserInClassrooms { get; set; }
    }
}