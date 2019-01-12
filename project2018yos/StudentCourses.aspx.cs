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
    public partial class StudentCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void idLecture_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();

            Lecture l = new Lecture(txtId.Text);
            if (l.checkIfLectureExsist())
            {
                lblmsn.Visible = false;
                string sql = "Select * From [DepartmentCourses] where Lecture='" + txtId.Text + "'";
                DataTable dt = DBFunctions.SelectFromTable(sql);

                GridViewLecture.DataSource = dt;
                DataBind();//להופעת טבלה
            }
            else
            {
                lblmsn.Visible = true;
                lblmsn.Text = "Error!!!!!!";
            } 
            
        }

        protected void btnStudent_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            string sql = "Select [Id_Course] From [StudentAtCourse] where Id_Student='" + txtId.Text + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            Students st = new Students(txtId.Text);
            if (st.checkIfStudentExsist())
            {

                Session["data"] = dt.Rows[0];
                if (dt.Rows.Count > 0)
                {
                    lblmsn.Visible = false;
                    string s = dt.Rows[0]["Id_Course"].ToString();
                    string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                    DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        s = dt.Rows[i]["Id_Course"].ToString();
                        sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                        DataTable dt3 = DBFunctions.SelectFromTable(sql2);
                        dt2.Merge(dt3);

                    }
                    GridViewStudent.DataSource = dt2;
                    DataBind();//להופעת טבלה
                }
            }
            else
            {
                lblmsn.Visible = true;
                lblmsn.Text = "Error!!";
            }
        }
        
    }
}