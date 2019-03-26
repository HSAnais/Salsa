using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class CreateIdea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"] != null) //if the user is loggged in
            {
                //change text to the user's department
                lblDepartment.Text = Session["uDepartment"].ToString();//hardcoded temporary value

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

            lblAuthorName.Text = Convert.ToString(Session["uName"]);

            //validation
            if (!IsPostBack)
            {
                lblAValid.Text = "";
                lblDValid.Text = "";
                lblTValid.Text = "";
            }

            //get tags from database
            /*List<> Tags = await new .GetTags(); 
             */
            //put tags in div
            /*listTags.DataSource = Tags;
             * listTags.DataBind();
             */

            tbxDescription.Attributes["placeholder"] = "Write about your idea...";

        }

        protected void BtnDoc_Click(object sender, EventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;

                tbxDocument.Attributes["placeholder"] = dlg.FileName;
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            //input validation
            if (txtTitle.Text == "")
            {
                lblTValid.Text = "Please fill in the title of your idea";
                Response.Redirect("CreateIdea.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            if (tbxDescription.Text == "")
            {
                lblDValid.Text = "Please fill in details of your idea";
                Response.Redirect("CreateIdea.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            if (authorType.SelectedIndex < 0)
            {
                lblAValid.Text = "Please choose how will your username be displayed";
                Response.Redirect("CreateIdea.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            if(terms.SelectedIndex < 0)
            {
                lblDValid.Text = "You have to agree with the Terms and conditions before submitting an idea";
                Response.Redirect("CreateIdea.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }
                

            //put in session the details for idea for display
            Session["iTitle"] = txtTitle.Text; //title

            if (authorType.SelectedIndex == 0) //author
                Session["iAuthor"] = lblAuthorName.Text;
            else
                Session["iAuthor"] = "Anonymous";

            Session["iDate"] = DateTime.Now;
            Session["iDetails"] = tbxDescription.Text;
            Session["iTitle"] = txtTitle.Text;
            Session["iVotes"] = 0;

            //push to database the new idea

            //redirect to the idea page
            Response.Redirect("IdeaPage.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
        
        protected void CL_ItemSelected(object sender, EventArgs e)
        {
            //loop through checkBoxList to select selected items
            foreach (ListItem item in listTags.Items)
            {
                if (item.Selected)
                    Session["iTags"] += item.Text + ", ";
            }
        }
    }
}