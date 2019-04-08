using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail; /*  library to send emails */
using System.Text;
using System.IO;

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
            //if (!IsPostBack)
            //{
            //    lblAValid.Text = "";
            //    lblDValid.Text = "";
            //    lblTValid.Text = "";
            //}

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
            //// Configure open file dialog box
            //Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            //dlg.FileName = "Document"; // Default file name
            //dlg.DefaultExt = ".txt"; // Default file extension
            //dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            //// Show open file dialog box
            //Nullable<bool> result = dlg.ShowDialog();

            //// Process open file dialog box results
            //if (result == true)
            //{
            //    // Open document
            //    string filename = dlg.FileName;

            //    tbxDocument.Attributes["placeholder"] = dlg.FileName;
            //}
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

            
                // The code to send an email notification to a QA Coordinator has been adapted from (Chris Merritt, 2014). 
              
                // MailMessage object called "message" takes parameters which are sender email addresses, receiver email address, the title and description of the email
                MailMessage message = new MailMessage("salsa.greenwich@gmail.com", "computing.ormount@gmail.com", txtTitle.Text, tbxDescription.Text);

                // We were unable to get the functionality to send emails to separate QA Coordinators
             
                // Smtp handles the delivery of emails to clients
                // SmtpClient object showing server information
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // host email and port number used 
                client.EnableSsl = true; // the mail server requires users to set the EnableSsl property to true to access the server (Microsoft, n.d.)
                client.Credentials = new System.Net.NetworkCredential("salsa.greenwich@gmail.com", "Salsateam1");
                /* NetworkCredential ojbect is set to the SmtpClient with the username and password
                 of the client which needs authentication (Behera, 2013)*/
                client.Send(message); // the send method is called to send the email
          

            bool isReady = true;

            //input validation
            if (txtTitle.Text == "")
            {
                lblTValid.Text = "Please fill in the title of your idea";
                isReady = false;
                return;
            }

            if (tbxDescription.Text == "")
            {
                lblDValid.Text = "Please fill in details of your idea";
                isReady = false;
                return;
            }

            if (authorType.SelectedIndex < 0)
            {
                lblAValid.Text = "Please choose how will your username be displayed";
                isReady = false;
                return;
            }

            //if(terms.SelectedIndex < 0)
            //{
            //    lblDValid.Text = "You have to agree with the Terms and conditions before submitting an idea";
            //    Response.Redirect("CreateIdea.aspx", false);
            //    Context.ApplicationInstance.CompleteRequest();
            //    return;
            //}
                

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


            // if anonymous is not clicked display user name
            if (authorType.SelectedValue == "0")
            {


               // userID = user.Id;
              //  userEmail = user.Email;


            }


            // file upload save in App_Data
            if (uploadFile.HasFile)
            {
                var filename = Path.GetFileName(uploadFile.FileName);
                var path = "/App_Data/" + filename;

                var trueFilepath = Path.Combine(Server.MapPath("~/App_Data/"), filename);

                uploadFile.SaveAs(trueFilepath);
                /*
                NewFile file = new NewFile()
                {
                    postId = newPost.postId,
                    filePath = path
                };
                using (var _dbContext = new ApplicationDbContext())
                {
                    _dbContext.Files.Add(file);
                    _dbContext.SaveChanges();
                }
                */
            }


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