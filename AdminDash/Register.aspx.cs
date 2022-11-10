using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminDash
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var FirstName = exampleFirstName.Text.Trim();
            var LastName = exampleLastName.Text.Trim();
            var UserName = exampleUsername.Text.Trim();
            var Contact = exampleInputPhone.Text.Trim();
            var Email = exampleInputEmail.Text.Trim();
            var Password = exampleInputPassword.Text.Trim();
            var Repeat = exampleRepeatPassword.Text.Trim();

            //if (FirstName == "")
            //{
            //    labelError.Text = "Enter FIrst name";
            //}

        }
    }
}