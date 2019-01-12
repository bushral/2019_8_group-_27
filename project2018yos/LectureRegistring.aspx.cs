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
    public partial class LectureRegistring : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // string n = null;
           // DataTable dt1 = null;
            string sql = "select * from [DepartmentCourses] where Department='" + Session["DepartmentLecture"] + "'and Lecture='null' and LectureName='null'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
           GridViewRegistering.DataSource = dt;
            DataBind();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt1 = null;
            string sql = "select * from DepartmentCourses where Department='" + Session["DepartmentLecture"] + "'and Lecture='null' and LectureName='null'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            GridViewRegistering.DataSource = dt;



            

            if (((CheckBox)GridViewRegistering.Rows[0].FindControl("CheckBox2")).Checked == true)
            {
                string s = dt.Rows[0]["IdCourse"].ToString();
                string sql1 = "select * from DepartmentCourses where IdCourse='" + s + "'";
                LectureOfCourse l = new LectureOfCourse(s, Session["ID_Lecture"].ToString());
                if (l.insertCourseForLecture())
                {
                    DepartmentCourses d = new DepartmentCourses(Session["ID_Lecture"].ToString(), Session["Lecture"].ToString(), s, Session["DepartmentLecture"].ToString());
                    d.UpdateRegisteringLecture();
                    lblMsn.Visible = true;
                    lblMsn.Text = "Has Been Added";
                }
                else
                {
                    lblMsn.Visible = true;
                    lblMsn.Text = "Error!";
                }
                dt1 = DBFunctions.SelectFromTable(sql1);

            }

            for (int i = 1; i < dt.Rows.Count; i++)
            {

                if (((CheckBox)GridViewRegistering.Rows[i].FindControl("CheckBox2")).Checked == true)
                {
                    string s = dt.Rows[i]["IdCourse"].ToString();
                    // string sql1 = "select * from DeaprtmentCourses where IdCourse='" + s + "'";
                    LectureOfCourse l = new LectureOfCourse(s, Session["ID_Lecture"].ToString());
                    if (l.insertCourseForLecture())
                    {
                        DepartmentCourses d = new DepartmentCourses(Session["ID_Lecture"].ToString(), Session["Lecture"].ToString(), s, Session["DepartmentLecture"].ToString());
                        d.UpdateRegisteringLecture();
                        lblMsn.Visible = true;
                        lblMsn.Text = "Has Been Added";
                    }
                    else
                    {
                        lblMsn.Visible = true;
                        lblMsn.Text = "Error!";
                    }
                    string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                    DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                    if (dt1 == null)
                        dt1 = dt2;
                    else
                        dt1.Merge(dt2);

                }
            }
            GridViewPrint.DataSource = dt1;
            DataBind();

        }

     /*       int num = 0;
            string sql = "select * from [DepartmentCourses] where Department='" + Session["Department"] + "' and Lecture='null' and LectureName='null'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            GridViewRegistering.DataSource = (dt);
            DataTable dt1=null;

            if (((CheckBox)GridViewRegistering.Rows[0].FindControl("CheckBox2")).Checked == true)
            {
                string s = dt.Rows[0]["IdCourse"].ToString();

                string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                string muchStudents = dt.Rows[0]["RegisteredStudents"].ToString();
                string maxStudent = dt.Rows[0]["MaxStudent"].ToString();
                // StudentAtCourse c = new StudentAtCourse(s, Session["ID"].ToString());
                LectureOfCourse l = new LectureOfCourse(s, Session["ID_Lecture"].ToString());
              //  if (Convert.ToInt32(muchStudents) < Convert.ToInt32(maxStudent))
               // {

                    if (l.insertCourseForLecture())
                    {
                    //  num = Convert.ToInt32(muchStudents) + 1;
                    DepartmentCourses d = new DepartmentCourses(Session["ID_Lecture"].ToString(), Session["Lecture"].ToString(), s, Session["DepartmentLecture"].ToString());
                        d.UpdateRegisteringLecture();
                        lblMsn.Visible = true;
                        lblMsn.Text = "Has Been Added";
                    }
                    else { lblMsn.Visible = true; lblMsn.Text = "Already Exsist!"; }
                    dt1 = DBFunctions.SelectFromTable(sql2);


               // }

            }
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (((CheckBox)GridViewRegistering.Rows[i].FindControl("CheckBox2")).Checked == true)
                {

                    string s = dt.Rows[i]["IdCourse"].ToString();

                    // string muchStudents = dt.Rows[i]["RegisteredStudents"].ToString();
                    //string maxStudent = dt.Rows[i]["MaxStudent"].ToString();
                    //StudentAtCourse c = new StudentAtCourse(s, Session["ID"].ToString());
                    LectureOfCourse l = new LectureOfCourse(s, Session["ID_Lecture"].ToString());

                    //  if (Convert.ToInt32(muchStudents) < Convert.ToInt32(maxStudent))
                    //{

                    if (l.insertCourseForLecture())
                    {
                        // num = Convert.ToInt32(muchStudents) + 1;
                        DepartmentCourses d = new DepartmentCourses(Session["ID_Lecture"].ToString(), Session["Lecture"].ToString(), s, Session["DepartmentLecture"].ToString());
                        d.UpdateRegisteringStudent();
                        lblMsn.Visible = true;
                        lblMsn.Text = "Has Been Added";
                    }

                    else { lblMsn.Visible = true; lblMsn.Text = "Already Exsist!"; }


                    // }

                    // else { lblMsn.Visible = true; lblMsn.Text = "There is no place in this course!"; }
                    string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                    DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                    if (dt1 == null)
                        dt1 = dt2;
                    else
                        dt1.Merge(dt2);
                }
            }
            GridViewPrint.DataSource=(dt1);
            //newDt = DBFunctions.CopyDataTable(dt1, dt1.Rows.Count);
            DataBind();
        }*/



    }

}
//}