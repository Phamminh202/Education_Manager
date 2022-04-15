using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class Attendance_Report
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Course_Id { get; set; }
        public bool Status { get; set; }
        public DateTime Create_Date { get; set; }

        public virtual Action action { get; set; }
        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}