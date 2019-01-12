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
            Server.Transfer("Login.aspx");
        }

        protected void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteCourse.aspx");
        }

        protected void btnAddCourse_Click(object sender, EventArgs e)
        {
            Server.Transfer("AddCourse.aspx");
        }

        protected void btnSoftware_Click(object sender, EventArgs e)
        {
            Server.Transfer("SoftwareCourses.aspx");
        }

        protected void btnMechanical_Click(object sender, EventArgs e)
        {
            Server.Transfer("mechanicalCourses.aspx");

        }

        protected void btnBulid_Click(object sender, EventArgs e)
        {
            Server.Transfer("buildingCourses.aspx");
        }

        protected void btnPrintCourses_Click(object sender, EventArgs e)
        {
            Server.Transfer("PrintCoursesAdmin.aspx");
            //pnlCourses.Visible = true;
        }

        protected void btnUpdateCourses_Click(object sender, EventArgs e)
        {
            Server.Transfer("UpdateCourses.aspx");
        }

        protected void btnPrintStudLec_Click(object sender, EventArgs e)
        {
            Server.Transfer("StudentCourses.aspx");
        }

        protected void btnHourStudent_Click(object sender, EventArgs e)
        {
            Server.Transfer("HoursOfStudents.aspx");
        }

        protected void btnMandCourses_Click(object sender, EventArgs e)
        {
            Server.Transfer("MandatoryCoursesAdmin.aspx");   }

        protected void BtnAddStudent_Click(object sender, EventArgs e)
        {
            Server.Transfer("AddStudent.aspx");
        }
    }
}