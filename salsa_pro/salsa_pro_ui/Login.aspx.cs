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
            //if (!IsPostBack)
            //{
            //    lblUValid.Text = "";
            //    lblPValid.Text = "";
            //}

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
            bool isReady = true;

            //input validation 
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblUValid.Text = "Please fill all fields";
                isReady = false;
                return; }

            if(txtPassword.Text == "wrong")
            {
                lblPValid.Text = "Wrong password";
                isReady = false;
                return;
            }
            //input check with database

            if(btnLogin.Text == "Logout")
            {
                Session["uName"] = null;
                Response.Redirect("Homepage.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }

            //put in session the details of user
            Session["uName"] = txtUsername.Text;
            Session["uDepartment"] = "Department of Life Sciences";
            Session["uRole"] = "Staff";

            switch (txtUsername.Text) {
                case "qam":
                    Session["uName"] = "Sarah Lovelace";
                    Session["uRole"] = "Quality Assurance Manager";
                    Session["uDepartment"] = "University of Ormount";
                    Response.Redirect("Dashboard.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                    break;
                case "qac":
                    Session["uName"] = "Jonathan Pine";
                    Session["uRole"] = "Quality Assurance Coordinator";
                    Session["uDepartment"] = "Department of Life Sciences";
                    Response.Redirect("Dashboard.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                    break;
                case "admin":
                    Session["uName"] = "Deborah Smith";
                    Session["uRole"] = "Administrator";
                    Session["uDepartment"] = "University of Ormount";
                    Response.Redirect("Dashboard.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                    break;
                default:
                    break;
            }
            //redirect to user profile
            if (isReady == true)
            {
                Response.Redirect("UserProfile.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }
    }
}