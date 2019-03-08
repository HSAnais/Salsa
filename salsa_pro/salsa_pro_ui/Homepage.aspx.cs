using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
                lblDepartment.Text = "Math";//hardcoded temporary value

            }

            //retrieve name of tags from databse and put them in checklist

            //get ideas for datalists - 5 IDEAS HAVE TO FIT THE WIDTH
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

        protected async void BtnSearch_Click(object sender, EventArgs e)
        {
            //search string
            string inputSearch = Convert.ToString(txtSearch.Text);

            //get selected tags
            int j = 0;
            for (int i = 0; i < listTags.Items.Count; i++)
                if (listTags.Items[i].Selected)
                    selectedTags[j++] = listTags.Items[i].Text;

            //push to database to retrieve matches for inputSearch and selectedTags[]

            //put in session results

            //redirect to results page
            Response.Redirect("SearchResults.aspx", false);
            Context.ApplicationInstance.CompleteRequest();

        }//BtnSearch_Click

        protected void SelectTag_Click(object sender, EventArgs e)
        {
            //do nothing; the search button includes instructions for selected tags
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

    }//class
}//namespace