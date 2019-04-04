using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail; /*  library to send email       */
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

            body.Attributes["placeholder"] = "Write about your idea...";

            to.Visible = false;
            from.Visible = false;

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                /* code for the message to be sent*/
                MailMessage message = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
                //  message.IsBodyHtml = true;

                /*Smtp relay which handles mail sending*/
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("lawdepartment.greenwich@gmail.com", "Salsateam1");
                client.Send(message);
                status.Text = "Mail was sent successfully!";

            }
            catch (Exception ex)
            {
                status.Text = ex.StackTrace; /* sees what the exception is*/
            }

            status.Text = "Mail was sent successfully!";
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