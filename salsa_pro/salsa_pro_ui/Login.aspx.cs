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

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            //input validation 

            //input check with database

            //put in session the details of user
            /*Session["uName"] = txtUsername.Text;
            */
            
            //redirect to user profile
            Response.Redirect("UserProfile.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}