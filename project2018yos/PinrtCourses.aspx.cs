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

    public partial class PinrtCourses : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (!IsPostBack)
            {
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
                    string h1 = "select HourStart from [DepartmentCourses] where IdCourse='" + s + "'";
                    string h2 = "select HourEnd from [DepartmentCourses] where IdCourse ='" + s + "'";
                    DataTable hourst = DBFunctions.SelectFromTable(h1);
                    DataTable houre = DBFunctions.SelectFromTable(h2);
                    string hs = hourst.Rows[0]["HourStart"].ToString();
                    string he = houre.Rows[0]["HourEnd"].ToString();
                    int countt = Math.Abs(Convert.ToInt32(hs) - Convert.ToInt32(he));
                    //  DataTable dtHours1 = DBFunctions.SelectFromTable(countt.ToString());

                    DataTable tott = DBFunctions.SelectFromTable(tot);
                    DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        s = dt.Rows[i]["Id_Course"].ToString();
                        sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "'";
                        tot = "select Credits from [DepartmentCourses] where IdCourse='" + s + "'";
                        h1 = "select HourStart from [DepartmentCourses] where IdCourse='" + s + "'";
                        h2 = "select HourEnd from [DepartmentCourses] where IdCourse ='" + s + "'";
                        DataTable hourst2 = DBFunctions.SelectFromTable(h1);
                        DataTable houre2 = DBFunctions.SelectFromTable(h2);
                        string hss = hourst2.Rows[0]["HourStart"].ToString();
                        string hee = houre2.Rows[0]["HourEnd"].ToString();
                        countt += Math.Abs(Convert.ToInt32(hss) - Convert.ToInt32(hee));

                        // DataTable dtHours2 = DBFunctions.SelectFromTable(count.ToString());
                        DataTable tt = DBFunctions.SelectFromTable(tot);
                        DataTable dt3 = DBFunctions.SelectFromTable(sql2);
                        dt2.Merge(dt3);
                        tott.Merge(tt);
                        // dtHours1.Merge(dtHours2);

                    }
                    // string cc = dtHours1.Rows[0].ToString();
                    int c = 0;
                    c += countt;
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
                    /*   for(int j=0;j<dtHours1.Rows.Count;j++)
                       {
                           cc = dtHours1.Rows[j].ToString();
                           c += Convert.ToInt32(cc);
                       }*/
                    lblFinalTot.Text = sum.ToString();
                    lblFinalHours.Text = c.ToString();

                    GridViewPrint.DataSource = dt2;
                    DataBind();//להופעת טבלה

                }
            }
        }

        protected void btnCurSem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
           
                int sum = 0, num;
                string sql = "Select [Id_Course] From [StudentAtCourse] where Id_Student='" + Session["ID"] + "'";
                DataTable dt = DBFunctions.SelectFromTable(sql);
                Session["data"] = dt.Rows[0];
                if (dt.Rows.Count > 0)
                {
                    string s = dt.Rows[0]["Id_Course"].ToString();
                    string sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "' and Year='"+ Session["YearStudent"]+"' and Semster='"+ Session["SemsterSud"] + "'";
                    // string totsql = "select Credits from [Courses] where ID='" + s + "'";
                    string tot = "select Credits from [DepartmentCourses] where IdCourse='" + s + "' and Year='" + Session["YearStudent"] + "' and Semster='" + Session["SemsterSud"] + "'";
                    string h1 = "select HourStart from [DepartmentCourses] where IdCourse='" + s + "' and Year='" + Session["YearStudent"] + "' and Semster='" + Session["SemsterSud"] + "'";
                    string h2 = "select HourEnd from [DepartmentCourses] where IdCourse ='" + s + "' and Year='" + Session["YearStudent"] + "' and Semster='" + Session["SemsterSud"] + "'";
                    DataTable hourst = DBFunctions.SelectFromTable(h1);
                    DataTable houre = DBFunctions.SelectFromTable(h2);
                DepartmentCourses hsd = new DepartmentCourses(s);

                    DataTable hss = hsd.sessionHourStart();

                    DataTable hee = hsd.sessionHourEnd();
                string hs = hss.Rows[0]["HourStart"].ToString();
                string he = hee.Rows[0]["HourEnd"].ToString();
                    int countt = Math.Abs(Convert.ToInt32(hs) - Convert.ToInt32(he));
                    //  DataTable dtHours1 = DBFunctions.SelectFromTable(countt.ToString());

                    DataTable tott = DBFunctions.SelectFromTable(tot);
                    DataTable dt2 = DBFunctions.SelectFromTable(sql2);
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        s = dt.Rows[i]["Id_Course"].ToString();
                        sql2 = "select * from [DepartmentCourses] where IdCourse= '" + s + "' and Year='" + Session["YearStudent"] + "' and Semster='" + Session["SemsterSud"] + "'";
                        tot = "select Credits from [DepartmentCourses] where IdCourse='" + s + "' and Year='" + Session["YearStudent"] + "' and Semster='" + Session["SemsterSud"] + "'";
                        h1 = "select HourStart from [DepartmentCourses] where IdCourse='" + s + "' and Year='" + Session["YearStudent"] + "' and Semster='" + Session["SemsterSud"] + "'";
                        h2 = "select HourEnd from [DepartmentCourses] where IdCourse ='" + s + "' and Year='" + Session["YearStudent"] + "' and Semster='" + Session["SemsterSud"] + "'";
                        DataTable hourst2 = DBFunctions.SelectFromTable(h1);
                        DataTable houre2 = DBFunctions.SelectFromTable(h2);
                    DepartmentCourses hssd = new DepartmentCourses(s);

                    DataTable hsss = hssd.sessionHourStart();

                    DataTable heee = hssd.sessionHourEnd();
                    string hs1 = hsss.Rows[0]["HourStart"].ToString();
                    string he1 = heee.Rows[0]["HourEnd"].ToString();
                 
                        countt += Math.Abs(Convert.ToInt32(hs1) - Convert.ToInt32(he1));

                        // DataTable dtHours2 = DBFunctions.SelectFromTable(count.ToString());
                        DataTable tt = DBFunctions.SelectFromTable(tot);
                        DataTable dt3 = DBFunctions.SelectFromTable(sql2);
                        dt2.Merge(dt3);
                        tott.Merge(tt);
                        // dtHours1.Merge(dtHours2);

                    }
                    // string cc = dtHours1.Rows[0].ToString();
                    int c = 0;
                    c += countt;
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
                int counttt = 0;
                    for(int a=0;a<dt2.Rows.Count;a++)
                {
                    s = dt2.Rows[a]["IdCourse"].ToString();
                    DepartmentCourses hssd = new DepartmentCourses(s);

                    DataTable hsss = hssd.sessionHourStart();

                    DataTable heee = hssd.sessionHourEnd();
                    string hs1 = hsss.Rows[0]["HourStart"].ToString();
                    string he1 = heee.Rows[0]["HourEnd"].ToString();

                     counttt += Math.Abs(Convert.ToInt32(hs1) - Convert.ToInt32(he1));

                }
                /*   for(int j=0;j<dtHours1.Rows.Count;j++)
                   {
                       cc = dtHours1.Rows[j].ToString();
                       c += Convert.ToInt32(cc);
                   }*/
                lblFinalTot.Text = sum.ToString();
                    lblFinalHours.Text = counttt.ToString();

                    GridViewPrint.DataSource = dt2;
                    DataBind();//להופעת טבלה

                }
          
        }
    }
    }