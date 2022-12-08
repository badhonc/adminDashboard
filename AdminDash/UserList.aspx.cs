using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
namespace AdminDash
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["uid"] == null)
            {
                Response.Redirect("login.aspx");
            }
            GetData();
        }

        private void GetData()
        {
            var list = UserCheck.FetchUser();
            if(list.Count() <= 0)
            {
                return;
            }
            GridView1.DataSource = list;
            GridView1.DataBind();
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            GridView1.FooterRow.TableSection = TableRowSection.TableFooter;
        }
    }
}