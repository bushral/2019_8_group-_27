using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2018yos
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            Admin A = new Admin(txtUserName.Text, txtID.Text);
            DataTable f = A.sessionId();
            if (A.logIn())
            {
                Session["Admin"] = txtUserName.Text;
                Session["AdminId"] = f.Rows[0]["ID"].ToString();
                Session["card"] = f.Rows[0]["CardNumber"].ToString();
                Server.Transfer("AdminROOM.aspx");
            }

            else
            {
                lblMSN.Text = " your username or ID is wrong";
                lblMSN.Visible = true;
            }

            txtUserName.Text = ""; //للتفريغ
            txtID.Text = "";
        }
    }
}