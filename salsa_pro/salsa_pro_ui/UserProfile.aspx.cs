using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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