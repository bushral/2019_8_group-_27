using project2018yos.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2018yos
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
           
       

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DepartmentCourses c = new DepartmentCourses(TextBoxDepartment.Text, TextBoxYear.Text, TextBoxSemester.Text, TextBoxName.Text, (Txtid.Text), TxtDay.Text, TextBoxhour.Text, txtHour2.Text, TextBoxCreadits.Text,TextBoxMandatory.Text,txtLec.Text,txtRegister.Text,txtMaxNum.Text,txtLecName.Text);
            if (c.insertCourse())
            {
                msg.Text = "has been add";
                msg.Visible = true;
                Txtid.Text = "";
                TxtDay.Text = "";
                TextBoxhour.Text = "";
                txtHour2.Text = "";
                TextBoxName.Text = "";
                TextBoxCreadits.Text = "";
                TextBoxDepartment.Text = "";
                TextBoxMandatory.Text = "";
                TextBoxYear.Text = "";
                TextBoxSemester.Text = "";
                txtLec.Text = "";
                txtRegister.Text = "";
                txtMaxNum.Text = "";
                txtLecName.Text = "";
            }

            else
            {
                msg.Text = "has not been add";
                msg.Visible = true;
            }
        }
    }
}