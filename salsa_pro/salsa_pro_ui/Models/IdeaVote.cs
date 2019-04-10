using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace salsa_pro_ui.Models
{
    public class IdeaVote
    {

        public int IdeaVote_Id { get; set; }
        public string IsLike { get; set; }
        public string Unlike { get; set; }
        public Idea Idea { get; set; }
        public int Idea_Id { get; set; }
        public ICollection<Idea> Ideas { get; set; }

        public IdeaVote()
        {
            Ideas = new Collection<Idea>();
        }
    }

}