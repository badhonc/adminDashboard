using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Dapper;


namespace AdminDash
{
    public partial class Login : System.Web.UI.Page
    {
        DbConnection dbConnection = new DbConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (userName.Text.Trim() == "" || passWord.Text.Trim() == "")
            {
                this.labelError.Text = "Please enter Username and Password";
                labelError.Visible = true;

            }
            else
            {
                this.labelError.Text = "";
                this.labelError.Visible = false;
                var username = userName.Text.Trim();
                var password = passWord.Text.Trim();
                //if (username == "badhon" && password == "123123")
                //{
                //    Response.Redirect("Default.aspx");
                //}
                var objUser = new Users
                {
                    Username = username,
                    Password = password
                };
                var user = UserCheck.CheckLogin(objUser);
                if(user != null)
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    labelError.Text = "Invalid Usernamr or Password";
                    labelError.Visible = true;
                }
                
            }
        }
    }
}