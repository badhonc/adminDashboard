using System;

namespace AdminDash
{
    internal abstract class Shape
    {
        public abstract double Area();
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double Area()
        {
            return 3.14 * radius * radius;
        }
    }
        public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                Circle c = new Circle(10.00);
            Label1.Text = c.Area().ToString();
            Console.WriteLine("Area of Circle = {0}", c.Area().ToString());
            System.Diagnostics.Debug.WriteLine("Area of Circle = {0}", c.Area().ToString());
            //auth
            //if (Request.Cookies["uname"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            Response.Write("Application used by:");
            Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name +"<br /> ");

            Response.Write("are u for real:");
            Response.Write(User.Identity.IsAuthenticated.ToString() + "<br/> ");

            Response.Write("Auth type:");
            Response.Write(User.Identity.AuthenticationType +"<br/>");

            Response.Write("User Name if authentiacated");
            Response.Write(Response.Cookies["uname"].Name);
        }
    }
}