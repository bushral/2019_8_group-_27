using project2018yos.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace project2018yos
{
    public partial class EnrollLecById : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from DepartmentCourses where Department='" + Session["DepartmentLecture"].ToString() + "' and Lecture='null' and LectureName='null'";
            DataTable d = DBFunctions.SelectFromTable(sql);
            GridViewlist.DataSource = d;
            DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DepartmentCourses nd = new DepartmentCourses(txtIdCourse.Text);
            if (nd.CheckCourseNull())
            {
                Lecture l = new Lecture(Session["ID_Lecture"].ToString());
                if (l.checkIfLectureExsist())
                {
                    LectureOfCourse lec = new LectureOfCourse(txtIdCourse.Text, Session["ID_Lecture"].ToString());
                    if (lec.insertCourseForLecture())
                    {
                        lblMsn.Visible = true;
                        lblMsn.Text = "Has Been Added";
                        DepartmentCourses dd = new DepartmentCourses(Session["ID_Lecture"].ToString(), Session["Lecture"].ToString(), txtIdCourse.Text, Session["DepartmentLecture"].ToString());
                        //dd.UpdateRegisteringLecture();
                        dd.updateLectureName();
                        dd.UdpateLectureId();
                        
                    }
                    else {
                        lblMsn.Visible = true;
                        lblMsn.Text = "Already Exsist!";
                    }
                }
                else
                {
                    lblMsn.Visible = true;
                    lblMsn.Text = "Lecture is not exsist";
                }
            }
            else
            {
                lblMsn.Visible = true;
                lblMsn.Text = "the course is unavailable ";
            }

            string sql = "select * from DepartmentCourses where Department='" + Session["DepartmentLecture"].ToString() + "' and Lecture='null' and LectureName='null'";
            DataTable d = DBFunctions.SelectFromTable(sql);
            GridViewlist.DataSource = d;
            DataBind();
        }
    }
}