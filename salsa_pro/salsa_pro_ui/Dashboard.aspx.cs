using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*//retrieve info based on role
             * switch(Session["uRole"])
             * {
             *      case "Quality Assurance Coordinator":
             *          List<> roleTasks = await new .GetNotifications();
             *          lblR.Text = "Notifications";
             *          lblDescription.Visible = true;
             *          btnEditSave.Visible = false;
             *          btnDelete.Visible = false;
             *          break;
             *      case "Quality Assurance Manager":
             *          List<> roleTasks = await new .GetTags();
             *          lblR.Text = "Idea tags";
             *          break;
             *      case "Admin":
             *          List<> roleTasks = await new .GetDates();
             *          lblR.Text = "Dates";
             *          break;
             *      default:
             *          break;
             * }
             * 
             * //role tasks
             * dlRole.DataSource = roleTasks;
             * dlRole.DataBind();
             * 
             * //BarChart
             * List<> barchart = await new  .GetBarStat();
             * dlBarChart.DataSource = barchart;
             * dlBarChart.DataBind();
             * 
             * //it would only go through the first set of labels
             * for(int i = 0; i< barchart.length; i +=3)
             *  {
             *      lblDep.Text = barchar[i];
             *      perIdeas.Width = barchar[i+1]/100;
             *      perContributors.Width = barchar[i+2]/100;
             *  }
             */
        }

        protected void BtnEditSave_Click(object sender, EventArgs e)
        {
            //get new input

            //push it to database


        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            //push to database that this item is deleted
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
                    //put in session all updates

                    //links
                    if (Session["uRole"] == "Quality Assurance Coordinator")
                    {
                        //redirect to Idea page 
                        Response.Redirect("IdeaPage.aspx", false);
                        Context.ApplicationInstance.CompleteRequest();
                    }
                    else
                    {
                        //reload page 
                        Response.Redirect("Dashboard.aspx", false);
                        Context.ApplicationInstance.CompleteRequest();
                    }
                }
                catch (System.Threading.ThreadAbortException)
                {
                    //Do nothing.  The exception will get rethrown by the framework when this block terminates.
                }
            }
        }//DL_ItemCommand
    }
}