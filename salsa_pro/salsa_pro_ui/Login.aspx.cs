using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace salsa_pro_ui
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUValid.Text = "";
            lblPValid.Text = "";

            if(Session["uName"]!=null)
            {
                btnLogin.Text = "Logout";
                txtPassword.Visible = false;
                txtUsername.Visible = false;
                lblUsername.Visible = false;
                lblPassword.Visible = false;

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
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            //input validation 
            if (txtUsername.Text == null || txtPassword.Text == null)
                lblUValid.Text = "Please fill all fields";

            //input check with database

            //put in session the details of user
            Session["uName"] = txtUsername.Text;

            switch (txtUsername.Text) {
                case "qam":
                    Session["uRole"] = "Quality Assurance Manager";
                    break;
                case "qac":
                    Session["uRole"] = "Quality Assurance Coordinator";
                    break;
                case "admin":
                    Session["uRole"] = "Administrator";
                    break;
                default:
                    break;
            }
            //redirect to user profile
            Response.Redirect("UserProfile.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}