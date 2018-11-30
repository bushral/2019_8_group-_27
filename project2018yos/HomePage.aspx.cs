using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2018yos
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdminLog_Click(object sender, EventArgs e)
        {
            pnlAdminLog.Visible = true;
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
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

        protected void btnStudent_Click(object sender, EventArgs e)
        {
            pnlStudent.Visible = true;
            //pnlNewStud.Visible = true;
        }

        protected void btnLucLOG_Click(object sender, EventArgs e)
        {
            pnlLogInLucture.Visible = true;
        }

        protected void btnLogStudent_Click(object sender, EventArgs e)
        {
            Students A = new Students(txtUserStudent.Text, txtIdSt.Text);
            DataTable f = A.sessionId();
            if (A.logIn())
            {
                Session["Student"] = txtUserStudent.Text;
                Session["ID"] = f.Rows[0]["ID"].ToString();
                // Session["card"] = f.Rows[0]["CardNumber"].ToString();
                Server.Transfer("StudentRoom.aspx");
            }

            else
            {
                lblMSN.Text = " your username or ID is wrong";
                lblMSN.Visible = true;
            }

            txtUserStudent.Text = ""; //للتفريغ
           txtIdSt.Text = "";
        }

        protected void btnLogLecture_Click(object sender, EventArgs e)
        {
            Lecture A = new Lecture(txtUserNameLucture.Text, txtIdLec.Text);
            DataTable f = A.sessionId();
            if (A.logIn())
            {
                Session["Lecture"] = txtUserNameLucture.Text;
                Session["ID"] = f.Rows[0]["ID"].ToString();
                // Session["card"] = f.Rows[0]["CardNumber"].ToString();
                Server.Transfer("LectureRoom.aspx");
            }

            else
            {
                lblMSN.Text = " your username or ID is wrong";
                lblMSN.Visible = true;
            }

            txtUserNameLucture.Text = ""; //للتفريغ
            txtIdLec.Text = "";
        }

        protected void logInStud_Click(object sender, EventArgs e)
        {
            Students S = new Students(txtUserStudent.Text, txtIdSt.Text);
            DataTable f = S.sessionId();
            if (S.logIn())
            {
                Session["Students"] = txtUserStudent.Text;
                Session["ID"] = f.Rows[0]["ID"].ToString();
                // Session["card"] = f.Rows[0]["CardNumber"].ToString();
                Server.Transfer("StudentRoom.aspx");
            }

            else
            {
                lblMSN.Text = " your username or ID is wrong";
                lblMSN.Visible = true;
            }

            txtUserStudent.Text = ""; //للتفريغ
            txtIdSt.Text = "";

        }
    }
}