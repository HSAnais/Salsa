using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class Browse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected async void BtnSort_Click(object sender, EventArgs e)
        {
            //take Session["tag"] as sorting parameter to request from database the results

            //put results in datalist
            /*List<> tResults = await new .GetIdeasByTag();
            dlTagResults.DataSource = tResults;
            dlTagResults.DataBind();

            lblTag.Text = "#" + Session["tag"].ToString();
             */
        }

        protected void SelectedTag(object sender, EventArgs e)
        {
           // Session["tag"] = listTags.SelectedItem.Text;
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