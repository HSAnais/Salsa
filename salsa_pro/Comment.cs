//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace salsa_pro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int Comment_Id { get; set; }
        public Nullable<int> User_Id { get; set; }
        public string CommentDetail { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> IsVisible { get; set; }
        public Nullable<bool> IsAnonymous { get; set; }
        public Nullable<int> Idea_Id { get; set; }
    
        public virtual Idea Idea { get; set; }
    }
}
