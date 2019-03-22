using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace salsa_pro_ui.Models
{
    public class Idea
    {
        //the class represent the state and behaviour of ideals

        
        
        public int IdeaId { get; set; }
      
        
        public virtual User Users { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
      
   
        public virtual IdeaTag IdeaTags { get; set; }
        public bool IsAnonymous { get; set; }

        public DateTime postDate { get; set; }
        public bool IsVisibile { get; set; }

    }
}