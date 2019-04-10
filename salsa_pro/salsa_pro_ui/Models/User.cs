using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace salsa_pro_ui.Models
{
    public class User
    {

        public int User_Id { get; set; }

        public ICollection<Idea> Ideas { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Department Department { get; set; }
        public int Department_Id { get; set; }

        public bool IsSuspened { get; set; }


        public bool IsVisibile { get; set; }
        public Role Role { get; set; }
        public int Role_Id { get; set; }

        public User()
        {
            Ideas = new Collection<Idea>();
        }

    }

}