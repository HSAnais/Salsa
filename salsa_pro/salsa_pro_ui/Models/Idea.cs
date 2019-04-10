using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace salsa_pro_ui.Models
{
    public class Idea
    {

        //the class represent the state and behaviour of ideals



        public int IdeaId { get; set; }


        // ForeignKey("User")]
        public ICollection<User> Users { get; set; }
        public string TitleOfIdea { get; set; }
        public string IdeaDetail { get; set; }

        // ForeignKey("User")]
        public User User { get; set; }
        public int User_Id { get; set; }
        public IdeaTag IdeaTag { get; set; }
        public int IdeaTag_Id { get; set; }
        public bool IsAnonymous { get; set; }

        public DateTime IdeaDate { get; set; }
        public bool IsVisibile { get; set; }

        public Idea()
        {
            Users = new Collection<User>();
        }
    }

}