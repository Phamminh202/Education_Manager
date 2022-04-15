using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education_Manager.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Role_Id { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}