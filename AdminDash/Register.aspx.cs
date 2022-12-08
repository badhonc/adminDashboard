using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace AdminDash
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            var FirstName = exampleFirstName.Text.Trim();
            var LastName = exampleLastName.Text.Trim();
            var UserName = exampleUsername.Text.Trim();
            var Contact = exampleInputPhone.Text.Trim();
            var Email = exampleInputEmail.Text.Trim();
            var Password = exampleInputPassword.Text.Trim();
            var Repeat = exampleRepeatPassword.Text.Trim();


            var user = new DAL.Users
            {
                Username = UserName,
                Password = Password,
                FirstName = FirstName,
                LastName = LastName,
                Email  = Email,
                Contact_No = Contact
            };
            if (Password != Repeat)
            {
                labelError.Text = "Password and Repeat Password must be same";
            }
            else
            {
                if (UserCheck.Insert(user))
                {

                    labelError.Text = "User Added Successfully";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('User Added Successfully'); window.location='https://" + Request.Url.Authority + Request.ApplicationPath + "Login.aspx';", true);
                    //Response.Redirect("Login.aspx");
                }
                else
                {
                    labelError.Text = "Error inserting";
                }
            }
        }
    }
}