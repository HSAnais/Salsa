using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            

            //put selected idea details in labels
            /*lblAuthor.Text = Convert.ToString(Session["iAuthor"]);
            lblTitle.Text = Convert.ToString(Session["iTitle"]);
            lblDate.Text = Convert.ToString(Session["iDate"]);
            lblVotes.Text = Convert.ToString(Session["iVotes"]);
            lblDetails.Text = Convert.ToString(Session["iDetails"]);
            */

            //reset variable for the current session
            user_Vote = 0;

            views++;

            //get comments for this idea
            //List<> comments = await new .GetComments(Convert.ToInt32(Session["iID"]));

            //put comments in DataList
            /*dlComments.DataSource = comments;
             *dlComments.DataBind();
             */

            tbxComment.Attributes["placeholder"] = "Write a comment...";
        }

        protected void btnAuthor_Click(object sender, EventArgs e)
        {
            //display messagebox
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