using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class Browse : System.Web.UI.Page
    {
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
            }

            //hardcoded data for demo
            //show all ideas if there is no sorting filter
            DataTable table = new DataTable();
            table.Columns.Add("Title");
            table.Columns.Add("Author");
            table.Columns.Add("Date");
            table.Columns.Add("Rating");
            table.Columns.Add("Details");
            table.Rows.Add("New cafeteria", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlTagResults.DataSource = table;
            dlTagResults.DataBind();

            /*//show all ideas by latest
            List<> iLastIdeas = await new .GetLastIdeas();
            dlTagResults.DataSource = iLastIdeas;
            dlTagResults.DataBind();
            */

            /*//get tags and put them in dropdown list
             * List<> tags = await new .GetTags();
             * listTags.DataSource = tags;
             * listTags.DataBind()
             */
        }

        protected void BtnSort_Click(object sender, EventArgs e)
        {
            //take Session["tag"] as sorting parameter to request from database the results

            //put results in datalist
            /*List<> tResults = await new .GetIdeasByTag();
            dlTagResults.DataSource = tResults;
            dlTagResults.DataBind();*/

            //lblTag.Text = "#" + Session["tag"].ToString();
            lblTag.Text = "#" + listTags.SelectedItem.Text;

            //hardcoded data for demo
            DataTable table1 = new DataTable();
            table1.Columns.Add("Title");
            table1.Columns.Add("Author");
            table1.Columns.Add("Date");
            table1.Columns.Add("Rating");
            table1.Columns.Add("Details");
            table1.Rows.Add("New cafeteria", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title", "Sachin Kumar", "25-03-2019", "24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlTagResults.DataSource = table1;
            dlTagResults.DataBind();
        }

        protected void SelectedTag(object sender, EventArgs e)
        {
           Session["tag"] = listTags.SelectedItem.Text;
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

        protected void DL_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //check if logged in
            if (Session["uName"] == null)
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                try
                {
                    //put in session all idea details to display in IdeaPage
                    Session["iTitle"] = ((Literal)e.Item.FindControl("Literal1")).Text;
                    Session["iAuthor"] = ((Literal)e.Item.FindControl("Literal2")).Text;
                    Session["iDate"] = ((Literal)e.Item.FindControl("Literal3")).Text;
                    Session["iVotes"] = ((Literal)e.Item.FindControl("Literal4")).Text;
                    Session["iDetails"] = ((Literal)e.Item.FindControl("Literal5")).Text;

                    //redirect to Idea page 
                    Response.Redirect("IdeaPage.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                catch (System.Threading.ThreadAbortException)
                {
                    //Do nothing.  The exception will get rethrown by the framework when this block terminates.
                }
            }
        }//DL_ItemCommand
    }
}