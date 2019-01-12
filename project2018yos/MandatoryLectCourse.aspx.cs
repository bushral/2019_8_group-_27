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
    public partial class MandatoryLectCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s="select * from DepartmentCourses where Department='"+ Session["DepartmentLecture"] + "' and Mandatory='Yes'";
            DataTable d = DBFunctions.SelectFromTable(s);
            GridViewMand.DataSource = d;
            DataBind();
        }
    }
}