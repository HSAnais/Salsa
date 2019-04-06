using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"] != null) //if the user is loggged in
            {
                //menu
                mLogin.Text = "Logout";

                if (Session["uRole"].ToString() == "Quality Assurance Manager" ||
                    Session["uRole"].ToString() == "Quality Assurance Coordinator" ||
                    Session["uRole"].ToString() == "Administrator")
                {
                    Response.Redirect("Dashboard.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                    return;
                }
            }
            else
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            /* if this is first login
             *  {
             *  lblWelcome.Visible = false;
             *  //load the user's name for welcome
                lblWelcome.Text = "Welcome, " + Convert.ToString(Session["uName"]) + "!";
                }
               else
               {
                lblLastLogin.Text = "Your last login was: " + ... ;
                lblLastLogin.Visible = true;
                }
            */
            lblLastLogin.Text = "Your last login was: 25-03-2019" ;
            lblLastLogin.Visible = true;

            lblWelcome.Text = "Welcome, " + Session["uName"].ToString() + "!";
            lblEmail.Text = Session["uName"].ToString()+"@osmount.ac.uk";

            //get ideas for DataLists
            /*List<> ideas = await new .GetIdeasByUser();
             *List<> comments = await new .GetComsByUser();
             */

            //put ideas in DataLists
            /*dlIdeas.DataSource = ideas;
             *dlIdeas.DataBind();
             * 
             *dlComments.DataSource = comments;
             *dlComments.DataBind();
             */

            //hardcoded data for demo
            //ideas
            DataTable table = new DataTable();
            table.Columns.Add("Title");
            table.Columns.Add("Author");
            table.Columns.Add("Date");
            table.Columns.Add("Rating");
            table.Columns.Add("Details");
            table.Rows.Add("New cafeteria", Session["uName"].ToString(), "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", Session["uName"].ToString(), "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", Session["uName"].ToString(), "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", Session["uName"].ToString(), "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", Session["uName"].ToString(), "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlIdeas.DataSource = table;
            dlIdeas.DataBind();

            //comments
            DataTable table1 = new DataTable();
            table1.Columns.Add("Title");
            table1.Columns.Add("ComDate");
            table1.Columns.Add("ComDetail");
            table1.Rows.Add("New cafeteria", "25-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title", "17-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title", "13-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title", "13-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title", "5-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlComments.DataSource = table1;
            dlComments.DataBind();
        }//Page_Load

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

        protected void DL_ItemCommand(object source, DataListCommandEventArgs e)
        {
            try
                {
                    //put in session all idea details to display in IdeaPage
                    //Session["iTitle"] = 
                    //Session["iAuthor"] = 
                    //Session["iDate"] = 
                    //Session["iVotes"] = 
                    //Session["iDetails"] = 

                    //redirect to Idea page 
                    Response.Redirect("IdeaPage.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            catch (System.Threading.ThreadAbortException)
                {
                    //Do nothing.  The exception will get rethrown by the framework when this block terminates.
                }
        }//DL_ItemCommand
    }
}