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
    public partial class PrintCoursesAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            if (DropDownDepartment.SelectedItem.Text.Equals("Software") && DropDownYear.SelectedItem.Text.Equals("1") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "software";
                Session["Year"] = "1";
                Session["Semester"] = "1";
                
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='1' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
              
            }
            if (DropDownDepartment.SelectedItem.Text.Equals("Software") && DropDownYear.SelectedItem.Text.Equals("1") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "software";
                Session["Year"] = "1";
                Session["Semester"] = "2";
               
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='1' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
                    DataBind();
                
            }



            if (DropDownDepartment.SelectedItem.Text.Equals("Software") && DropDownYear.SelectedItem.Text.Equals("2") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "software";
                Session["Year"] = "2";
                Session["Semester"] = "1";
                
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='2' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
}


            if (DropDownDepartment.SelectedItem.Text.Equals("Software") && DropDownYear.SelectedItem.Text.Equals("2") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "software";
                Session["Year"] = "2";
                Session["Semester"] = "2";
                
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='2' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
                
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Software") && DropDownYear.SelectedItem.Text.Equals("3") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "software";
                Session["Year"] = "3";
                Session["Semester"] = "1";
                
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='3' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
                
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Software") && DropDownYear.SelectedItem.Text.Equals("3") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "software";
                Session["Year"] = "3";
                Session["Semester"] = "2";
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='3' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
                
              
            }

            if (DropDownDepartment.SelectedItem.Text.Equals("Software") && DropDownYear.SelectedItem.Text.Equals("4") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "software";
                Session["Year"] = "4";
                Session["Semester"] = "1";
               
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='4' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Software") && DropDownYear.SelectedItem.Text.Equals("4") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "software";
                Session["Year"] = "4";
                Session["Semester"] = "2";
               
                    string sql = "select * from [DepartmentCourses] where Department='software'and Year='4' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
             
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Structual") && DropDownYear.SelectedItem.Text.Equals("1") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "structual";
                Session["Year"] = "1";
                Session["Semester"] = "1";
              
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='1' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
               
            }

            if (DropDownDepartment.SelectedItem.Text.Equals("Structual") && DropDownYear.SelectedItem.Text.Equals("1") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "structual";
                Session["Year"] = "1";
                Session["Semester"] = "2";
              
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='1' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
              
            }

            if (DropDownDepartment.SelectedItem.Text.Equals("Structual") && DropDownYear.SelectedItem.Text.Equals("2") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "structual";
                Session["Year"] = "2";
                Session["Semester"] = "1";
               
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='2' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
              
            }

            if (DropDownDepartment.SelectedItem.Text.Equals("Structual") && DropDownYear.SelectedItem.Text.Equals("2") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "structual";
                Session["Year"] = "2";
                Session["Semester"] = "2";
              
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='2' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
               
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Structual") && DropDownYear.SelectedItem.Text.Equals("3") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "structual";
                Session["Year"] = "3";
                Session["Semester"] = "1";

                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='3' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
              
            }

            if (DropDownDepartment.SelectedItem.Text.Equals("Structual") && DropDownYear.SelectedItem.Text.Equals("3") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "structual";
                Session["Year"] = "3";
                Session["Semester"] = "2";
               
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='3' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
              
            }

            if (DropDownDepartment.SelectedItem.Text.Equals("Structual") && DropDownYear.SelectedItem.Text.Equals("4") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "structual";
                Session["Year"] = "4";
                Session["Semester"] = "1";
               
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='4' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
               
            }

            if (DropDownDepartment.SelectedItem.Text.Equals("Structual") && DropDownYear.SelectedItem.Text.Equals("4") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "structual";
                Session["Year"] = "4";
                Session["Semester"] = "2";
               
                    string sql = "select * from [DepartmentCourses] where Department='structual'and Year='4' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
               
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Mechanical") && DropDownYear.SelectedItem.Text.Equals("1") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "mechanical";
                Session["Year"] = "1";
                Session["Semester"] = "1";
             
                    string sql = "select * from [DepartmentCourses] where Department='Mechanical'and Year='1' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
                
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Mechanical") && DropDownYear.SelectedItem.Text.Equals("1") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "mechanical";
                Session["Year"] = "1";
                Session["Semester"] = "2";
               
                    string sql = "select * from [DepartmentCourses] where Department='Mechanical'and Year='1' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
              
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Mechanical") && DropDownYear.SelectedItem.Text.Equals("2") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "mechanical";
                Session["Year"] = "2";
                Session["Semester"] = "1";
                
                    string sql = "select * from [DepartmentCourses] where Department='Mechanical'and Year='2' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
             
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Mechanical") && DropDownYear.SelectedItem.Text.Equals("2") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "mechanical";
                Session["Year"] = "2";
                Session["Semester"] = "2";
               
                    string sql = "select * from [DepartmentCourses] where Department='Mechanical'and Year='2' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
               
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Mechanical") && DropDownYear.SelectedItem.Text.Equals("3") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "mechanical";
                Session["Year"] = "3";
                Session["Semester"] = "1";
               
                    string sql = "select * from [DepartmentCourses] where Department='Mechanical'and Year='3' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
              
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Mechanical") && DropDownYear.SelectedItem.Text.Equals("3") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "mechanical";
                Session["Year"] = "3";
                Session["Semester"] = "2";
               
                    string sql = "select * from [DepartmentCourses] where Department='Mechanical'and Year='3' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
               
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Mechanical") && DropDownYear.SelectedItem.Text.Equals("4") && DropDownSemster.Text.Equals("1"))
            {
                Session["Department"] = "mechanical";
                Session["Year"] = "4";
                Session["Semester"] = "1";
               
                    string sql = "select * from [DepartmentCourses] where Department='Mechanical'and Year='4' and Semster='1'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
               
            }


            if (DropDownDepartment.SelectedItem.Text.Equals("Mechanical") && DropDownYear.SelectedItem.Text.Equals("4") && DropDownSemster.Text.Equals("2"))
            {
                Session["Department"] = "mechanical";
                Session["Year"] = "4";
                Session["Semester"] = "2";
             
                    string sql = "select * from [DepartmentCourses] where Department='Mechanical'and Year='4' and Semster='2'";
                    DataTable dt = DBFunctions.SelectFromTable(sql);
                    GridViewPrint.DataSource = (dt);
                    DataBind();
               
            }



        }
    }
}