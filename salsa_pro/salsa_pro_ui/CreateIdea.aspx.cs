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
            lblAuthorName.Text = Convert.ToString(Session["uName"]);

            //get tags from database
            /*List<> Tags = await new .GetTags(); 
             */
            //put tags in div
            /*listTags.DataSource = Tags;
             * listTags.DataBind();
             */

            tbxDescription.Attributes["placeholder"] = "Write about your idea...";


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
          

            //input validation

            //put in session the details for idea for display
            /*Session["iTitle"] = txtTitle.Text;
            Session["iAuthor"] = 
            Session["iDate"] = DateTime.Now;
            Session["iDetails"] = tbxDescription.Text;
            */

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