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
    public partial class CourseRegistering : System.Web.UI.Page
    {
        DataTable dt1;
        DataTable newDt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["YearStudent"].ToString() == "1" && Session["SemsterSud"].ToString() == "1")
            {
                DropDownYear.Items.Add("1");
                //DropDownYear.Items.Add("2");
                //DropDownSemster.Items.Add("1");
                DropDownSemster.Items.Add("2");

            }

            if (Session["YearStudent"].ToString() == "1" && Session["SemsterSud"].ToString() == "2")
            {
                // DropDownYear.Items.Add("1");
                DropDownYear.Items.Add("2");
                DropDownSemster.Items.Add("1");
                //DropDownSemster.Items.Add("2");
            }

            if (Session["YearStudent"].ToString() == "2" && Session["SemsterSud"].ToString() == "1")
            {
                //DropDownYear.Items.Add("1");
                DropDownYear.Items.Add("2");
                //DropDownSemster.Items.Add("1");
                DropDownSemster.Items.Add("2");

            }
            if (Session["YearStudent"].ToString() == "2" && Session["SemsterSud"].ToString() == "2")
            {
                DropDownYear.Items.Add("3");
                //DropDownYear.Items.Add("2");
                DropDownSemster.Items.Add("1");
                // DropDownSemster.Items.Add("2");

            }
            if (Session["YearStudent"].ToString() == "3" && Session["SemsterSud"].ToString() == "1")
            {
                DropDownYear.Items.Add("3");
                //DropDownYear.Items.Add("2");
                // DropDownSemster.Items.Add("1");
                DropDownSemster.Items.Add("2");

            }

            if (Session["YearStudent"].ToString() == "3" && Session["SemsterSud"].ToString() == "2")
            {
                DropDownYear.Items.Add("4");
                //DropDownYear.Items.Add("2");
                DropDownSemster.Items.Add("1");
                //  DropDownSemster.Items.Add("2");

            }
            if (Session["YearStudent"].ToString() == "4" && Session["SemsterSud"].ToString() == "1")
            {
                DropDownYear.Items.Add("4");
                //DropDownYear.Items.Add("2");
                // DropDownSemster.Items.Add("1");
                DropDownSemster.Items.Add("2");

            }

            if (Session["YearStudent"].ToString() == "4" && Session["SemsterSud"].ToString() == "2")
            {
                DropDownYear.Items.Add("1");
                DropDownYear.Items.Add("2");
                DropDownYear.Items.Add("3");
                DropDownYear.Items.Add("4");
                DropDownSemster.Items.Add("1");
                DropDownSemster.Items.Add("2");

            }

        }



        protected void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridViewAdded.Rows.Count; i++)
            {
                if (((CheckBox)GridViewAdded.Rows[i].FindControl("CheckBox1")).Checked == true)
                {
                    string s = dt1.Rows[i]["IdCourse"].ToString();
                    string sql2 = "delete * from [StudentAtCourse] where IdCourse= '" + s + "'";
                    DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                    if (dt1 == null)
                        dt1 = dt2;
                    else
                        dt1.Merge(dt2);

                }
            }
            GridViewAdded.DataSource = (dt1);
            DataBind();
        }

        protected void DropDownYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSeacrh_Click(object sender, EventArgs e)
        {
            if (DropDownYear.SelectedItem.Text.Equals("1") && DropDownSemster.Text.Equals("1"))
            {

                Session["Year"] = "1";
                Session["Semester"] = "1";
                if (Session["DepartmentStud"].ToString() == "software")
                {
                    Session["Department"] = "software";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='1' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "structual")
                {
                    Session["Department"] = "structual";
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='1' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }
                if (Session["DepartmentStud"].ToString() == "mechanical")
                {
                    Session["Department"] = "mechanical";
                    string sql = "select * from [DepartmentCourses] where Department='mechanical'and Year='1' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }


            }
            if (DropDownYear.SelectedItem.Text.Equals("1") && DropDownSemster.Text.Equals("2"))
            {
                // Session["Department"] = "software";
                Session["Year"] = "1";
                Session["Semester"] = "2";
                if (Session["DepartmentStud"].ToString() == "software")
                {
                    Session["Department"] = "software";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='1' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                    DataBind();
                }
                if (Session["DepartmentStud"].ToString() == "structual")
                {
                    Session["Department"] = "sturctual";
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='1' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "mechanical")
                {
                    Session["Department"] = "mechanical";
                    string sql = "select * from [DepartmentCourses] where Department='mechanical'and Year='1' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                    DataBind();
                }

            }



            if (DropDownYear.SelectedItem.Text.Equals("2") && DropDownSemster.Text.Equals("1"))
            {

                Session["Year"] = "2";
                Session["Semester"] = "1";

                if (Session["DepartmentStud"].ToString() == "software")
                {
                    Session["Department"] = "software";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='2' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }
                if (Session["DepartmentStud"].ToString() == "structual")
                {
                    Session["Department"] = "structual";
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='2' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }
                if (Session["DepartmentStud"].ToString() == "mechanical")
                {
                    Session["Department"] = "mechanical";
                    string sql = "select * from [DepartmentCourses] where Department='mechanical'and Year='2' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }



            }


            if (DropDownYear.SelectedItem.Text.Equals("2") && DropDownSemster.Text.Equals("2"))
            {
                // Session["Department"] = "software";
                Session["Year"] = "2";
                Session["Semester"] = "2";
                if (Session["DepartmentStud"].ToString() == "software")
                {
                    Session["Department"] = "software";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='2' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "structual")
                {
                    Session["Department"] = "structual";
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='2' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "mechanical")
                {
                    Session["Department"] = "mechanical";
                    string sql = "select * from [DepartmentCourses] where Department='mechanical'and Year='2' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

            }


            if (DropDownYear.SelectedItem.Text.Equals("3") && DropDownSemster.Text.Equals("1"))
            {

                Session["Year"] = "3";
                Session["Semester"] = "1";
                if (Session["DepartmentStud"].ToString() == "software")
                {
                    Session["Department"] = "software";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='3' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "structual")
                {
                    Session["Department"] = "structual";
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='3' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }
                if (Session["DepartmentStud"].ToString() == "mechanical")
                {
                    Session["Department"] = "mechanical";
                    string sql = "select * from [DepartmentCourses] where Department='mechanical'and Year='3' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

            }


            if (DropDownYear.SelectedItem.Text.Equals("3") && DropDownSemster.Text.Equals("2"))
            {

                Session["Year"] = "3";
                Session["Semester"] = "2";
                if (Session["DepartmentStud"].ToString() == "software")
                {
                    Session["Department"] = "software";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='3' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "structual")
                {
                    Session["Department"] = "structual";
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='3' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "mechanical")
                {
                    Session["Department"] = "mechanical";
                    string sql = "select * from [DepartmentCourses] where Department='mechanical'and Year='3' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

            }

            if (DropDownYear.SelectedItem.Text.Equals("4") && DropDownSemster.Text.Equals("1"))
            {

                Session["Year"] = "4";
                Session["Semester"] = "1";
                if (Session["DepartmentStud"].ToString() == "software")
                {

                    Session["Department"] = "software";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='4' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "structual")
                {

                    Session["Department"] = "structual";
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='4' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

                if (Session["DepartmentStud"].ToString() == "mechanical")
                {

                    Session["Department"] = "mechanical";
                    string sql = "select * from [DepartmentCourses] where Department='mechanical'and Year='4' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }



            }


            if (DropDownYear.SelectedItem.Text.Equals("4") && DropDownSemster.Text.Equals("2"))
            {

                Session["Year"] = "4";
                Session["Semester"] = "2";
                if (Session["DepartmentStud"].ToString() == "software")
                {
                    Session["Department"] = "software";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='4' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }
                if (Session["DepartmentStud"].ToString() == "structual")
                {
                    Session["Department"] = "structual";
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='4' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }
                if (Session["DepartmentStud"].ToString() == "mechanical")
                {
                    Session["Department"] = "mechanical";
                    string sql = "select * from [DepartmentCourses] where Department='mechanical'and Year='4' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewRegistering.DataSource = (dt);
                    DataBind();
                }

            }



            BTNADDED.Visible = true;
        }

        protected void BTNADDED_Click1(object sender, EventArgs e)
        {
            int num = 0;
            string sql = "select * from [DepartmentCourses] where Department='" + Session["Department"] + "' and Year='" + Session["Year"] + "' and Semster='" + Session["Semester"] + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            GridViewRegistering.DataSource = (dt);
            //  DataTable dt1=null;

            if (((CheckBox)GridViewRegistering.Rows[0].FindControl("CheckBox1")).Checked == true)
            {
                string s = dt.Rows[0]["IdCourse"].ToString();

                string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                string muchStudents = dt.Rows[0]["RegisteredStudents"].ToString();
                string maxStudent = dt.Rows[0]["MaxStudent"].ToString();
                StudentAtCourse c = new StudentAtCourse(s, Session["ID"].ToString());
                if (Convert.ToInt32(muchStudents) < Convert.ToInt32(maxStudent))
                {
                  
                    if (c.insertCourseForStudent())
                    {
                        num = Convert.ToInt32(muchStudents) + 1;
                        DepartmentCourses d = new DepartmentCourses(num.ToString(), maxStudent, s);
                        d.UpdateRegisteringStudent();
                        lblMsn.Visible = true;
                        lblMsn.Text = "Has Been Added";
                    }
                    else { lblMsn.Visible = true; lblMsn.Text = "Already Exsist!"; }
                    dt1 = DBFunctions.SelectFromTable(sql2);


                }

            }
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (((CheckBox)GridViewRegistering.Rows[i].FindControl("CheckBox1")).Checked == true)
                {

                    string s = dt.Rows[i]["IdCourse"].ToString();
              
                    string muchStudents = dt.Rows[i]["RegisteredStudents"].ToString();
                    string maxStudent = dt.Rows[i]["MaxStudent"].ToString();
                    StudentAtCourse c = new StudentAtCourse(s, Session["ID"].ToString());


                    if (Convert.ToInt32(muchStudents) < Convert.ToInt32(maxStudent))
                    {
                       
                        if (c.insertCourseForStudent())
                        {
                            num = Convert.ToInt32(muchStudents) + 1;
                            DepartmentCourses d = new DepartmentCourses(num.ToString(), maxStudent, s);
                            d.UpdateRegisteringStudent();
                            lblMsn.Visible = true;
                            lblMsn.Text = "Has Been Added";
                        }

                        else { lblMsn.Visible = true; lblMsn.Text = "Already Exsist!"; }
                       

                    }

                    else { lblMsn.Visible = true; lblMsn.Text = "There is no place in this course!"; }
                    string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                    DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                    if (dt1 == null)
                        dt1 = dt2;
                    else
                        dt1.Merge(dt2);
                }
            }
            GridViewAdded.DataSource = (dt1);
            newDt = DBFunctions.CopyDataTable(dt1, dt1.Rows.Count);
            DataBind();
        }

        protected void btnCancel_Click1(object sender, EventArgs e)
        {
            /* DataTable data=null;
             string sql = "select [Id_Course] from [StudentAtCourse] where Id_Student='" + Session["ID"] + "'";
             DataTable dt = DBFunctions.SelectFromTable(sql);
             int h = dt.Rows.Count;
            if (h>0)
             {
                 string s = dt.Rows[0]["Id_Course"].ToString();
                 string year = "select Year from [DepartmentCourses] where IdCourse= '" + s + "'";
                 string sem = "select semester from [DeaprtmentCourses] where IdCourse='" + s + "'";
                 if(Session["Year"].ToString()==year && Session["Semester"].ToString()==sem)
                 {
                     string sql1 = "select * from [DepartmentCourses] where IdCourse='" + s + "'";
                      data = DBFunctions.SelectFromTable(sql1);
                 }

                 for(int d = 1; d < h; d++)
                 {
                      s = dt.Rows[0]["Id_Course"].ToString();
                      year = "select Year from [DepartmentCourses] where IdCourse= '" + s + "'";
                     sem = "select semester from [DeaprtmentCourses] where IdCourse='" + s + "'";
                     if (Session["Year"].ToString() == year && Session["Semester"].ToString() == sem)
                     {
                         string sql2 = "select * from [DepartmentCourses] where IdCourse='" + s + "'";
                         DataTable data2 = DBFunctions.SelectFromTable(sql2);
                         data.Merge(data2);
                     }
                     else
                     {
                         h = h - 1;
                     }


                 }
                 GridViewAdded.DataSource = data;
                 DataBind();

             }*/


            string sql = "select * from [DepartmentCourses] where Department='" + Session["Department"] + "' and Year='" + Session["Year"] + "' and Semster='" + Session["Semester"] + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            GridViewRegistering.DataSource = (dt);
            for (int j = 0; j < GridViewAdded.Rows.Count; j++)
            {
                    if (((CheckBox)GridViewAdded.Rows[j].FindControl("CheckBox1")).Checked == true)
                    {
                        string s = GridViewAdded.Rows[j].ToString();
                        StudentAtCourse ss = new StudentAtCourse(s, Session["ID"].ToString());
                        if (ss.DeleteCourseForStudent())
                        {
                        string muchStudents = dt.Rows[j]["RegisteredStudents"].ToString();
                        string maxStudent = dt.Rows[j]["MaxStudent"].ToString();
                        int num = Convert.ToInt32(muchStudents) -1;
                        DepartmentCourses d = new DepartmentCourses(num.ToString(), maxStudent, s);
                        d.UpdateRegisteringStudent();

                        lblMsn.Text = "Has Been Deleted";
                            GridViewAdded.Rows[j].Visible = false;
                        }
                        else lblMsn.Text = "Is Already not exsist";

                    }

                    else
                    {
                        string s = dt.Rows[j]["IdCourse"].ToString();
                        string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                        DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                        if (dt1 == null)
                            dt1 = dt2;
                        else
                            dt1.Merge(dt2);


                    }

                }
                GridViewAdded.DataSource = (dt1);
                DataBind();
            }
        
    }
}