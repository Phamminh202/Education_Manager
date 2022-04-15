using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Education_Manager.Models
{
    public class educationmanagerContext : DbContext
    {
        public educationmanagerContext() : base("educationmanager") { }

        public virtual DbSet<Academicyear> Academicyears { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Attendance_Report> Attendance_Reports { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Exams> Exams { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student_Fee> Student_Fees { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserInAcademicyear> UserInAcademicyears { get; set; }
        public virtual DbSet<UserInClassroom> UserInClassrooms { get; set; }
        public virtual DbSet<UserInCourse> UserInCourses { get; set; }
        public virtual DbSet<UserInExams> UserInExams { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    }
}