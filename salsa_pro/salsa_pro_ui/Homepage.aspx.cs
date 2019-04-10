using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class Homepage : System.Web.UI.Page
    {
        string[] selectedTags;

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
            
            //hardcoded data for demo
            //trending
            DataTable table = new DataTable();
            table.Columns.Add("Title");
            table.Columns.Add("Author");
            table.Columns.Add("Date");
            table.Columns.Add("Rating");
            table.Columns.Add("Details");
            table.Rows.Add("New cafeteria", "Sachin Kumar", "25-03-2019","75", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title of Idea", "Sachin Kumar", "15-01-2019", "68", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title of Idea", "Sachin Kumar", "27-02-2019", "49", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title of Idea", "Sachin Kumar", "23-02-2019", "47", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title of Idea", "Sachin Kumar", "20-01-2019", "40", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlTrending.DataSource = table;
            dlTrending.DataBind();

            //most viewed
            DataTable table1 = new DataTable();
            table1.Columns.Add("Title");
            table1.Columns.Add("Author");
            table1.Columns.Add("Date");
            table1.Columns.Add("Rating");
            table1.Columns.Add("Details");
            table1.Rows.Add("New cafeteria", "Sachin Kumar", "25-03-2019", "75", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title of Idea", "Sachin Kumar", "23-02-2019", "43", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title of Idea", "Sachin Kumar", "17-02-2019", "31", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title of Idea", "Sachin Kumar", "5-02-2019", "81", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table1.Rows.Add("Title of Idea", "Sachin Kumar", "25-01-2019", "56", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlMostViewed.DataSource = table1;
            dlMostViewed.DataBind();

            //latest ideas
            DataTable table2 = new DataTable();
            table2.Columns.Add("Title");
            table2.Columns.Add("Author");
            table2.Columns.Add("Date");
            table2.Columns.Add("Rating");
            table2.Columns.Add("Details");
            table2.Rows.Add("New cafeteria", "Sachin Kumar", "25-03-2019", "75", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table2.Rows.Add("Title of Idea", "Sachin Kumar", "24-03-2019", "3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table2.Rows.Add("Title of Idea", "Sachin Kumar", "23-03-2019", "7", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table2.Rows.Add("Title of Idea", "Sachin Kumar", "22-03-2019", "14", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table2.Rows.Add("Title of Idea", "Sachin Kumar", "21-03-2019", "12", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlLastIdeas.DataSource = table2;
            dlLastIdeas.DataBind();

            //latest comments
            DataTable table3 = new DataTable();
            table3.Columns.Add("Title");
            table3.Columns.Add("ComDate");
            table3.Columns.Add("ComDetail");
            table3.Rows.Add("New cafeteria", "25-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table3.Rows.Add("Title", "17-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table3.Rows.Add("Title", "13-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table3.Rows.Add("Title", "13-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table3.Rows.Add("Title", "5-03-2019", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            dlLastComs.DataSource = table3;
            dlLastComs.DataBind();

            //get ideas for datalists
            /*List<> iTrending = await new .GetIdeasByVotes();
             *List<> iMostViewed = await new .GetIdeasByViews();
             *List<> iLastIdeas =  await new .GetLastIdeas();
             *List<> iLastComms = await new .GetLastComs(); 
             */

            //put ideas in DataLists
            /* dlTrending.DataSource = iTrending;
             * dlTrending.DataBind();
             * 
             * dlMostViewed.DataSource = iMostViewed;
             * dlMostViewed.DataBind();
             * 
             * dlLastIdeas.DataSource = iLastIdeas;
             * dlLastIdeas.DataBind();
             * 
             * dlLastComs.DataSource = iLastIdeas;
             * dlLastComs.DataBind();
             */

        }//Page_Load

        //protected async void BtnSearch_Click(object sender, EventArgs e)
        //{
        //    //search string
        //    string inputSearch = Convert.ToString(txtSearch.Text);

        //    //get selected tags
        //    int j = 0;
        //    for (int i = 0; i < listTags.Items.Count; i++)
        //        if (listTags.Items[i].Selected)
        //            selectedTags[j++] = listTags.Items[i].Text;

        //    //push to database to retrieve matches for inputSearch and selectedTags[]

        //    //put in session results

        //    //redirect to results page
        //    Response.Redirect("SearchResults.aspx", false);
        //    Context.ApplicationInstance.CompleteRequest();

        //}//BtnSearch_Click

        //protected void SelectTag_Click(object sender, EventArgs e)
        //{
        //    //do nothing; the search button includes instructions for selected tags
        //}

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

    }//class
}//namespace