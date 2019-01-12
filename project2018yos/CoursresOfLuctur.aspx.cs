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
    public partial class CoursresOfLuctur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DepartmentCourses cc = new DepartmentCourses(Session["ID_Lecture"].ToString());
            //lbltest.Text = Session["ID_Lecture"].ToString();
            //Lecture c = new Lecture(Session["ID_Lecture"].ToString());
            if (!IsPostBack)
            {
                string sql = "Select * From [DepartmentCourses] where Lecture='"+Session["ID_Lecture"]+"'";
                DataTable dt = DBFunctions.SelectFromTable(sql);
                GridViewLuctureCourses.DataSource = dt;
                DataBind(); //להופעת טבלה

            }
            int sum = 0;
            string sqlCredits = "select Credits from [DepartmentCourses] where Lecture='" + Session["ID_Lecture"] + "'";
            DataTable dt1 = DBFunctions.SelectFromTable(sqlCredits);
           // while (dt1.Rows.Count > 0) {  sum = sum + dt1.ToString(); }
             lblTotalCredits.Text =sum.ToString(); 



        }
    }
}