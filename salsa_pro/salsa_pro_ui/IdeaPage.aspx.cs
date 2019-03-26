using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class IdeaPage : System.Web.UI.Page
    {
        int user_Vote;
        int views;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"] != null) //if the user is loggged in
            {
                //change text to the user's department
                lblDepartment.Text = "Department of " + Session["uDepartment"].ToString();//hardcoded temporary value

                //menu
                mLogin.Text = "Logout";

                if (Session["uRole"].ToString() == "Quality Assurance Manager" ||
                    Session["uRole"].ToString() == "Quality Assurance Coordinator" ||
                    Session["uRole"].ToString() == "Administrator")
                {
                    mProfile.Text = "Dashboard";
                    aProfile.HRef = "Dashboard.aspx";
                }
            }
            else
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            tbxComment.Attributes["placeholder"] = "Write a comment...";

            if (Session["iTitle"] == null)
            {
                lblAuthor.Text = "Josephine Mouse";
                lblTitle.Text = "New system for recycling";
                lblDate.Text = "01-03-2019";
                lblVotes.Text = "35";
                lblDetails.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam pharetra nisi ullamcorper risus porta pharetra. Vivamus sed elementum ex. Ut non tempus dui, sed varius augue. Proin tincidunt velit sit amet justo euismod cursus. Curabitur placerat, nibh ac vulputate blandit, ex odio dapibus odio, eget malesuada nunc ipsum ut nisl.";
            }
            else
            {
                //put selected idea details in labels
                lblAuthor.Text = Convert.ToString(Session["iAuthor"]);
                lblTitle.Text = Convert.ToString(Session["iTitle"]);
                lblDate.Text = Convert.ToString(Session["iDate"]);
                lblVotes.Text = Convert.ToString(Session["iVotes"]);
                lblDetails.Text = Convert.ToString(Session["iDetails"]);
            }

            //reset variable for the current session
            user_Vote = 0;
            views++;

            //get comments for this idea
            //List<> comments = await new .GetComments(Convert.ToInt32(Session["iID"]));

            //put comments in DataList
            /*dlComments.DataSource = comments;
             *dlComments.DataBind();
             */
                     

            //hardcoded data for demo
            //comments
            DataTable table = new DataTable();
            table.Columns.Add("Author");
            table.Columns.Add("Date");
            table.Columns.Add("Details");
            table.Rows.Add("Sachin Kumar", "25-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add( "Josephine Mouse", "17-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add( "Carol Danvers", "13-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add( "Michael Burman", "13-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add( "Sachin Kumar", "5-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlComments.DataSource = table;
            dlComments.DataBind();
        }

        protected void voteUp_Click(object sender, EventArgs e)
        {
            user_Vote = Convert.ToInt32(Session["iVotes"]);
            user_Vote--;

            lblVotes.Text = user_Vote.ToString();

            //push to database the new vote
        }

        protected void voteDown_Click(object sender, EventArgs e)
        {
            user_Vote = Convert.ToInt32(Session["iVotes"]);
            user_Vote++;

            lblVotes.Text = user_Vote.ToString();

            //push to database the new vote
        }

        protected void DL_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //Add eventhandlers for highlighting a DataListItem when the mouse hovers over it.
                //highlight solved in css
                e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor='transparent'");

                //Add eventhandler for simulating a click on the 'SelectButton'
                e.Item.Attributes.Add("onclick",
                       this.Page.ClientScript.GetPostBackEventReference(
                       e.Item.Controls[1], string.Empty));
            }
        }//DL_ItemDataBound

        protected void BtnCom_Click(object sender, EventArgs e)
        {
            //input validation
            if (tbxComment.Text == null)
                return;

            //put in session the details of comment
            /*
            Session["cDate"] = Date.Now();

            Session["cAuthor"] = Session["uName"];
            Session["iComment"] = tbxComment.Text;
            */

            //push to database the new comment

            //redirect to the idea page
            Response.Redirect("IdeaPage.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}