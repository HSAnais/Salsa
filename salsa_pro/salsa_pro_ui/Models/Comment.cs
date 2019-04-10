using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace salsa_pro_ui.Models
{
    public class Comment
    {
        public int Comment_Id { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentBody { get; set; }
        public bool IsVisibility { get; set; }

        public bool IsAnonymous { get; set; }
        public Idea Idea { get; set; }
        public int Idea_Id { get; set; }
        public User User { get; set; }
        public int User_Id { get; set; }
        //ForeignKey("idea")]
        public ICollection<Idea> Ideas { get; set; }

        // ForeignKey("User")]
        public ICollection<User> Users { get; set; }



        public Comment()
        {
            Ideas = new Collection<Idea>();
            Users = new Collection<User>();
        }


    }

}