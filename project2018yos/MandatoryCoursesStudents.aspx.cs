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
    public partial class MandatoryCoursesStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                string sql = "select * from [DepartmentCourses] where Department='software' and Mandatory='Yes'";
                    DataTable dt=DBFunctions.SelectFromTable(sql);
         
                    GridViewMandatoryCourses.DataSource = dt;
                    DataBind();//להופעת טבלה

                }

            }

        }
    }
