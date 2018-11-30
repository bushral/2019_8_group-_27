using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2018yos
{
    public partial class AdminRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogOutAdmin_Click(object sender, EventArgs e)
        {
            Server.Transfer("HomePage.aspx");
        }

        protected void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteCourse.aspx");
        }

        protected void btnAddCourse_Click(object sender, EventArgs e)
        {
            Server.Transfer("AddCourse.aspx");
        }
    }
}