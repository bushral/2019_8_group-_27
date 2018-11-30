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
            Courses c = new Courses(Txtid.Text, TxtDay.Text, TextBoxhour.Text, TextBoxName.Text, Convert.ToInt32(TextBoxCreadits.Text), TextBoxDepartment.Text, TextBoxMandatory.Text, TextBoxYear.Text, TextBoxSemester.Text);
            if (c.insertCourse())
            {
                msg.Text = "has been add";
                msg.Visible = true;
                Txtid.Text = "";
                TxtDay.Text = "";
                TextBoxhour.Text = "";
                TextBoxName.Text = "";
                TextBoxCreadits.Text = "";
                TextBoxDepartment.Text = "";
                TextBoxMandatory.Text = "";
                TextBoxYear.Text = "";
                TextBoxSemester.Text = "";
            }

            else
            {
                msg.Text = "has not been add";
                msg.Visible = true;
            }
        }
    }
}