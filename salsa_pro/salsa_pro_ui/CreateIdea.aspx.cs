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

            //validation
            //lblAValid.Text = "";
            //lblDValid.Text = "";
            //lblTValid.Text = "";

            //get tags from database
            /*List<> Tags = await new .GetTags(); 
             */
            //put tags in div
            /*listTags.DataSource = Tags;
             * listTags.DataBind();
             */

            tbxDescription.Attributes["placeholder"] = "Write about your idea...";

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            //input validation
            if (txtTitle.Text == "")
            {
                lblTValid.Text = "Please fill in the title of your idea";
                Response.Redirect("CreateIdea.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }

            if (tbxDescription.Text == "")
                lblDValid.Text = "Please fill in details of your idea";
            if (authorType.SelectedIndex < 0)
                lblAValid.Text = "Please choose how will your username be displayed";

            //put in session the details for idea for display
            Session["iTitle"] = txtTitle.Text;
            if (authorType.SelectedIndex == 0)
                Session["iAuthor"] = lblAuthorName.Text;
            else
                Session["iAuthor"] = "Anonymous";

            Session["iDate"] = DateTime.Now;
            Session["iDetails"] = tbxDescription.Text;
            Session["iTitle"] = txtTitle.Text;

            //push to database the new idea

            //redirect to the idea page
            Response.Redirect("IdeaPage.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
        
        protected void CL_ItemSelected(object sender, EventArgs e)
        {
            //loop through checkBoxList to select selected items
            foreach (ListItem item in listTags.Items)
            {
                if (item.Selected)
                    Session["iTags"] += item.Text + ", ";
            }
        }
    }
}