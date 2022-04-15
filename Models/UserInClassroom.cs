using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class UserInClassroom
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Class_Id { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual User User { get; set; }
    }
}