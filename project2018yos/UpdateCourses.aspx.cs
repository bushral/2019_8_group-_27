using project2018yos.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2018yos
{
    public partial class UpdateCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExploreCourse_Click(object sender, EventArgs e)
        {
            DepartmentCourses L = new DepartmentCourses(txtIdCourse.Text);
            DataTable f = null;
            f = L.UpdateExsistCourse();
            if (f != null)
            {
                //txtNameHotel.Text = f.Rows[0]["Name_HVA"].ToString();
                Session["IdCourse"] = txtIdCourse;
                pnlUpdtaeMandatory.Visible = true;

            }
            else
            {
                lblMsn.Text = " the Id of Course not Exsist";
                lblMsn.Visible = true;
                pnlUpdtaeMandatory.Visible = false;

            }

        }

        protected void dropUpdateMandatory_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            string f = "";
            if (dropUpdateMandatory.SelectedItem.Text.Equals("Yes"))
            {
                f = "Yes";
                Session["Drop"] = "Yes";
            }
            if (dropUpdateMandatory.SelectedItem.Text.Equals("No"))
            {
                f = "No";
                Session["Drop"] = "No";
            }
            return Session["Drop"].ToString();
            */
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // Courses L = new Courses();
            if (dropUpdateMandatory.SelectedItem.Text.Equals("No"))
            {
                Session["Drop"] = "No";
                //DepartmentCourses c1 = new DepartmentCourses(txtIdCourse.Text);
                DepartmentCourses c = new DepartmentCourses(txtIdCourse.Text, Session["Drop"].ToString());
                c.UpdateCourses();
                lblMsn.Visible = true;
                lblMsn.Text = "Successfully Update it";
            }

            if (dropUpdateMandatory.SelectedItem.Text.Equals("Yes"))
            {
                Session["Drop"] = "Yes";
                DepartmentCourses c = new DepartmentCourses(txtIdCourse.Text, Session["Drop"].ToString());
                c.UpdateCourses();
                lblMsn.Visible = true;
                lblMsn.Text = "Successfully Update it";

            }
        }

    }
}