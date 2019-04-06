using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class Dashboard : System.Web.UI.Page
    {
        //protected global::System.Web.UI.WebControls.Label lblDescription;
        //protected global::System.Web.UI.WebControls.Label lblTitle;
        //protected global::System.Web.UI.WebControls.Button btnEditSave;
        //protected global::System.Web.UI.WebControls.Button btnDelete;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uName"] != null)
                mLogin.Text = "Logout";

            lblRole.Text = Session["uRole"].ToString();
            lblWelcome.Text = "Welcome, " + Session["uName"].ToString() + "!";

            //hardcoded data for demo
            //notifications
            DataTable table = new DataTable();
            table.Columns.Add("Title");
            table.Columns.Add("Details");
            table.Rows.Add("New cafeteria", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");
            table.Rows.Add("Title", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis metus vel velit placerat, eu consequat nunc maximus. Nulla quis ipsum sed arcu hendrerit dapibus. Duis pulvinar efficitur enim, nec eleifend justo congue nec. Sed hendrerit feugiat diam finibus mattis. ");

            //tags
            DataTable table1 = new DataTable();
            table1.Columns.Add("Title");
            table1.Columns.Add("Details");
            table1.Rows.Add("maintenance");
            table1.Rows.Add("paperwork");
            table1.Rows.Add("campus");
            table1.Rows.Add("students");
            table1.Rows.Add("course");
            table1.Rows.Add("events");

            //dates
            DataTable table2 = new DataTable();
            table2.Columns.Add("Title");
            table2.Columns.Add("Details");
            table2.Rows.Add("23-05-2019");
            table2.Rows.Add("30-06-2019");
            table2.Rows.Add("18-07-2019");

            //retrieve info based on role
            switch (Session["uRole"])
              {
                   case "Quality Assurance Coordinator":
                    lblDescription.Text = "";
                    dlRole.DataSource = table;
                    dlRole.DataBind();
                    lblR.Text = "Notifications";
                    btnEditSave.Visible = false;
                    btnDelete.Visible = false;
                    lblDescription.Visible = true;
                    //List<> roleTasks = await new .GetNotifications();
                    break;
                   case "Quality Assurance Manager":
                    dlRole.DataSource = table1;
                    dlRole.DataBind();
                    //List<> roleTasks = await new .GetTags();
                    lblR.Text = "Idea tags";                        
                    break;
                   case "Admin":
                    dlRole.DataSource = table2;
                    dlRole.DataBind();
                    //List<> roleTasks = await new .GetDates();
                    lblR.Text = "Dates";                        
                    break;
                   default:
                       break;
              }
            
            /* //role tasks
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

            Response.Redirect("Dashboard.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
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
                    if (Session["uRole"].ToString() == "Quality Assurance Coordinator")
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