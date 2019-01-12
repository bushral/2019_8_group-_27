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
    public partial class DeleteStdById : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (!IsPostBack)
            {
                int sum = 0, num;
                string sql = "Select [Id_Course] From [StudentAtCourse] where Id_Student='" + Session["ID"] + "'";
                DataTable dt = DBFunctions.SelectFromTable(sql);
                //Session["data"] = dt.Rows[0];
                if (dt.Rows.Count > 0)
                {
                    string s = dt.Rows[0]["Id_Course"].ToString();
                    string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                    // string totsql = "select Credits from [Courses] where ID='" + s + "'";
                    string tot = "select Credits from [DepartmentCourses] where IdCourse='" + s + "'";
                    DataTable tott = DBFunctions.SelectFromTable(tot);
                    DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        s = dt.Rows[i]["Id_Course"].ToString();
                        sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                        tot = "select Credits from [DepartmentCourses] where IdCourse='" + s + "'";
                        DataTable tt = DBFunctions.SelectFromTable(tot);
                        DataTable dt3 = DBFunctions.SelectFromTable(sql2);
                        dt2.Merge(dt3);
                        tott.Merge(tt);

                    }

                    string ss = tott.Rows[0]["Credits"].ToString();
                    num = Convert.ToInt32(ss);
                    sum = num;
                    //  txttot.Text = tott.Rows.Count.ToString();
                    // string totsql = "select Credits from [Courses] where ID='" + s + "'";
                    // DataTable newdt = DBFunctions.SelectFromTable(totsql);
                    for (int i = 1; i < tott.Rows.Count; i++)
                    {
                        ss = tott.Rows[i]["Credits"].ToString();
                        sum += Convert.ToInt32(ss);
                    }

                    lblFinalTot.Text = sum.ToString();


                    GridViewDelete.DataSource = dt2;
                    DataBind();//להופעת טבלה

                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            StudentAtCourse nd = new StudentAtCourse(txtIdCourse.Text, Session["ID"].ToString());
            if (nd.DeleteCourseForStudent())
            {
                string re = "select * from StudentAtCourse where Id_Course='" + txtIdCourse.Text + "'";
                DataTable dr = DBFunctions.SelectFromTable(re);
                DepartmentCourses ds = new DepartmentCourses(txtIdCourse.Text);
               // int muchStudent=Convert.ToInt32( ds.sessionMuchStudent());
               
                
                 DataTable dtmaxStudent = ds.sessionMaxStudents();
                string maxStudent = dtmaxStudent.Rows[0]["maxStudent"].ToString();
                //int num11 = (muchStudent) - 1;
                int r = dr.Rows.Count;
                if (r == 0)
                {
                    // r--;
                    DepartmentCourses d1 = new DepartmentCourses("0", maxStudent,txtIdCourse.Text);
                    d1.UpdateRegisteringStud();

                }
                else
                {
                    r--;
                    DepartmentCourses d1 = new DepartmentCourses(r.ToString(), maxStudent,txtIdCourse.Text);
                    d1.UpdateRegisteringStud();
                }

                lblMsn.Visible = true;
                lblMsn.Text = "Has Been Delete it!";
            }
            else
            {
                lblMsn.Visible = true;
                lblMsn.Text = "Not Exsist!";
            }
            int sum = 0, num;
            string sql = "Select [Id_Course] From [StudentAtCourse] where Id_Student='" + Session["ID"] + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            Session["data"] = dt.Rows[0];
            if (dt.Rows.Count > 0)
            {
                string s = dt.Rows[0]["Id_Course"].ToString();
                string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                // string totsql = "select Credits from [Courses] where ID='" + s + "'";
                string tot = "select Credits from [DepartmentCourses] where IdCourse='" + s + "'";
                DataTable tott = DBFunctions.SelectFromTable(tot);
                DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    s = dt.Rows[i]["Id_Course"].ToString();
                    sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                    tot = "select Credits from [DepartmentCourses] where IdCourse='" + s + "'";
                    DataTable tt = DBFunctions.SelectFromTable(tot);
                    DataTable dt3 = DBFunctions.SelectFromTable(sql2);
                    dt2.Merge(dt3);
                    tott.Merge(tt);

                }

                string ss = tott.Rows[0]["Credits"].ToString();
                num = Convert.ToInt32(ss);
                sum = num;
                //  txttot.Text = tott.Rows.Count.ToString();
                // string totsql = "select Credits from [Courses] where ID='" + s + "'";
                // DataTable newdt = DBFunctions.SelectFromTable(totsql);
                for (int i = 1; i < tott.Rows.Count; i++)
                {
                    ss = tott.Rows[i]["Credits"].ToString();
                    sum += Convert.ToInt32(ss);
                }

                lblFinalTot.Text = sum.ToString();


                GridViewDelete.DataSource = dt2;
                DataBind();//להופעת טבלה

            }
        }
  }
}