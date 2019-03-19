using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class CreateIdea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAuthorName.Text = Convert.ToString(Session["uName"]);

            //get tags from database

            //put tags in div

            tbxDescription.Attributes["placeholder"] = "Write about your idea...";

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            //input validation

            //put in session the details for idea for display
            /*Session["iTitle"] = txtTitle.Text;
            Session["iAuthor"] = 
            Session["iDate"] = DateTime.Now;
            Session["iDetails"] = tbxDescription.Text;
            */

            //push to database the new idea

            //redirect to the idea page
            Response.Redirect("IdeaPage.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}