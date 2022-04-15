using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Attendance_Report> Attendance_Reports { get; set; }
        public virtual ICollection<Exams> Exams { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        public virtual ICollection<UserInCourse> UserInCourses { get; set; }
    }
}