using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2018yos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMSN.Visible = false;
        }
        /*
           <asp:Button ID="btnLogIN" runat="server" CssClass="btn" Text="Log In" OnClick="btnLogIN_Click" />
        protected void btnLogIN_Click(object sender, EventArgs e)
        {
            Admin A = new Admin(txtUserName.Text, txtID.Text);
            DataTable f = A.sessionId();
            if (A.logIn())
            {
                Session["Admin"] = txtUserName.Text;
                Session["ID"] = f.Rows[0]["ID"].ToString();
               // Session["card"] = f.Rows[0]["CardNumber"].ToString();
                Server.Transfer("AdminRoom.aspx");
            }

            else
            {
                lblMSN.Text = " your username or ID is wrong";
                lblMSN.Visible = true;
            }

            txtUserName.Text = ""; //للتفريغ
            txtID.Text = "";
        }
        */

        protected void btnLogAsAdmin_Click(object sender, EventArgs e)
        {
            Admin A = new Admin(txtUserName.Text, txtID.Text);
            DataTable f = A.sessionId();
            if (A.logIn())
            {
                Session["Admin"] = txtUserName.Text;
                Session["ID"] = f.Rows[0]["ID"].ToString();
                // Session["card"] = f.Rows[0]["CardNumber"].ToString();
                Server.Transfer("AdminRoom.aspx");
            }

            else
            {
                lblMSN.Text = " your username or ID is wrong";
                lblMSN.Visible = true;
            }

            txtUserName.Text = ""; //للتفريغ
            txtID.Text = "";
        }


        protected void btnLogAsLecture_Click(object sender, EventArgs e)
        {
            Lecture A = new Lecture(txtUserName.Text, txtID.Text);
            DataTable f = A.sessionId();
            DataTable f2 = A.sessionDepartment();
            if (A.logIn())
            {
                Session["Lecture"] = txtUserName.Text;
                Session["ID"] = f.Rows[0]["ID"].ToString();
                Session["ID_Lecture"] = f.Rows[0]["ID"].ToString();
                Session["DepartmentLecture"] = f2.Rows[0]["Department"];
                // Session["card"] = f.Rows[0]["CardNumber"].ToString();
                Server.Transfer("PrintLecCourses.aspx");
              //  Server.Transfer("ccll.aspx");
            }

            else
            {
                lblMSN.Text = " your username or ID is wrong";
                lblMSN.Visible = true;
            }

            txtUserName.Text = ""; //للتفريغ
            txtID.Text = "";
        }

        protected void btnLogAsStudent_Click(object sender, EventArgs e)
        {
            Students A = new Students(txtUserName.Text, txtID.Text);
            DataTable f = A.sessionId();
            DataTable f2 = A.sessionDepartment();
            DataTable f3 = A.sessionYear();
            DataTable f4 = A.sessionSemster();
            if (A.logIn())
            {
                Session["Student"] = txtUserName.Text;
                Session["ID"] = f.Rows[0]["ID"].ToString();
                Session["YearStudent"] = f3.Rows[0]["Year"].ToString();
                Session["DepartmentStud"] = f2.Rows[0]["Department"].ToString();
                Session["SemsterSud"] = f4.Rows[0]["Semester"].ToString();
                Server.Transfer("StudentArea.aspx");

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