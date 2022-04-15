using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Password { get; set; }
        public DateTime Date_of_birth { get; set; }
        public string Gender { get; set; }
        public byte[] Avatar { get; set; }
        public string ID_card { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Create_date { get; set; }


        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Attendance_Report> Attendance_Reports { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Parent> Parents { get; set; }
        public virtual ICollection<Student_Fee> Student_Fees { get; set; }
        public virtual ICollection<UserInAcademicyear> UserInAcademicyears { get; set; }
        public virtual ICollection<UserInClassroom> UserInClasses { get; set; }
        public virtual ICollection<UserInCourse> UserInCourses { get; set; }
        public virtual ICollection<UserInExams> UserInExams { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}