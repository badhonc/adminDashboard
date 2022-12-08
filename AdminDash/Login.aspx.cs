using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Dapper;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;
using System.Web.Services.Description;

namespace AdminDash
{
    public partial class Login : System.Web.UI.Page
    {

        DbConnection dbConnection = new DbConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            string lblerr = labelError.Text.Trim();
           // InitializeComponent();
        }
        //private void InitializeComponent()
        //{
        //    this.btnLogin.Click += new EventHandler(btnLogin_Click);
        //}
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var username = userName.Text.Trim();
            var password = passWord.Text.Trim();
            if (userName.Text.Trim() == "" || passWord.Text.Trim() == "")
            {
                this.labelError.Text = "Please enter Username and Password";
                labelError.Visible = true;

            }
            else
            {
                this.labelError.Text = "";
                this.labelError.Visible = false;
                //if (username == "badhon" && password == "123123")
                //{
                //    Response.Redirect("Default.aspx");
                //}
                var objUser = new Users
                {
                    Username = username,
                    Password = password
                };
                Users user = UserCheck.CheckLogin(objUser);
                if (user == null)
                {
                    labelError.Text = "Invalid Username or Password";
                    labelError.Visible = true;
                }
                else
                {
                if (ValidateUser(username, password))
                {
                    FormsAuthenticationTicket tkt;
                    string cookiestr;
                    HttpCookie ck;
                     HttpCookie uname = new HttpCookie(Convert.ToString(username));
                    tkt = new FormsAuthenticationTicket(1, username, DateTime.Now,
                    DateTime.Now.AddMinutes(30), chkPersistCookie.Checked, "im custom data");
                    cookiestr = FormsAuthentication.Encrypt(tkt);
                    ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                    if (chkPersistCookie.Checked)
                        ck.Expires = tkt.Expiration;
                    ck.Path = FormsAuthentication.FormsCookiePath;
                    Response.Cookies.Add(ck);
                        Response.Cookies.Add(uname);

                    string strRedirect;
                    strRedirect = Request["ReturnUrl"] + Request.Cookies["uname"];
                        if (strRedirect == "")
                        {
                            //Response.Redirect("home.aspx", true);
                            Response.Redirect("https://localhost:44359/Home.aspx");
                        }
                        else
                            Response.Redirect("Login.aspx", true);
                }
                
            }
        }
    }
        private bool ValidateUser(string userName, string passWord)
        {
            var conn = DbConnection.GetConnection();
            SqlCommand cmd;
            string lookupPassword = passWord;

            // Check for invalid userName.
            // userName must not be null and must be between 1 and 15 characters.
            if ((null == userName) || (0 == userName.Length) || (userName.Length > 15))
            {
                System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of userName failed.");
                return false;
            }

            // Check for invalid passWord.
            // passWord must not be null and must be between 1 and 25 characters.
            if ((null == passWord) || (0 == passWord.Length) || (passWord.Length > 25))
            {
                System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of passWord failed.");
                return false;
            }

            try
            {

                // Consult with your SQL Server administrator for an appropriate connection
                // string to use to connect to your local SQL Server.
                //conn = DbConnection.GetConnection();

                //Create SqlCommand to select pwd field from users table given supplied userName.
                cmd = new SqlCommand("select password from users where user_name=@userName", conn);
                cmd.Parameters.Add("@userName", SqlDbType.VarChar, 25);
                cmd.Parameters["@userName"].Value = userName;

                //Execute command and fetch pwd field into lookupPassword string.
               lookupPassword = (string)cmd.ExecuteScalar();

                //Cleanup command and connection objects.
               cmd.Dispose();
               conn.Dispose();
            }
            catch (Exception ex)
            {
                // Add error handling here for debugging.
                // This error message should not be sent back to the caller.
                System.Diagnostics.Trace.WriteLine("[ValidateUser] Exception " + ex.Message);
            }

            // If no password found, return false.
            if (null == lookupPassword)
            {
                // You could write failed login attempts here to event log for additional security.
                return false;
                //this.labelError.Text = "Invalid Username or Password";
                //labelError.Visible = true;
            }

            // Compare lookupPassword and input passWord, using a case-sensitive comparison.
            return (0 == string.Compare(lookupPassword, passWord, false));
        }
    }
}