using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace salsa_pro_ui.Models
{
    public class User 
    {
        public int UserId { get; set; }


        public virtual Idea Ideas { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public virtual IdeaTag IdeaTags { get; set; }
        public bool IsSuspened { get; set; }

       
        public bool IsVisibile { get; set; }

    }
}