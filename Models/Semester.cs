using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class Semester
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Student_Fee> Student_Fees { get; set; }
    }
}