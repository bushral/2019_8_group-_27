using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2018yos
{
    public partial class LogInStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogStudent_Click(object sender, EventArgs e)
        {
            Students S = new Students(txtNameSutdent.Text, txtIdStud.Text);
            
            
        }
    }
}