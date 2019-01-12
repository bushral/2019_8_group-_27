using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1;

namespace project2018yos
{
    public class Courses
    {
        public  string ID;
        public string Day;
        public string Hour;
        public string CourseName;
        public string  Credits;
        public string Department;
        public string Mandatory;
        public string Year;
        public string Semester;
        public string Lecture;

        public Courses(string id) { this.ID = id; }
        public Courses(string man,string s) { this.ID= man;  this.Mandatory= s; }
        //public Courses(string v) { this.Mandatory = v; }

        public Courses(string id,string d,string h,string name,string credit,string depart,string mand,string y,string semster,string lec)
        {
            this.ID = id;
            this.Day = d;
            this.Hour = h;
            this.CourseName = name;
            this.Credits = credit;
            this.Mandatory = mand;
            this.Year = y;
            this.Semester = semster;
            this.Lecture = lec;

            

        }


        public bool CheckExist()
        {
            string sql = "Select * From [Courses] Where Id='" + this.ID+ "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public bool insertCourse()
        {

            if (!CheckExist())
            {
                string sql = " INSERT INTO [Courses] ([ID],[Day],[Hour],[CourseName],[Credits],[Department],[Mandatory],[Year],[Semester],[Lecture])";
                string sql2 = "VALUES ('" + this.ID + "','" + this.Day + "','" + this.Hour + "','" + this.CourseName + "','" + this.Credits + "','" + this.Department + "','" + this.Mandatory + "','"+this.Year+"','"+this.Semester+"','"+this.Lecture+"')";
                DBFunctions.ChangTable(sql + sql2);
                return true;
            }

            return false;

        }




        public bool DeleteHotel()
        {
            if (CheckExist())
            {
                string x = "Delete From [Courses] Where ID='" + this.ID + "'";
                DBFunctions.ChangTable(x);
                return true;

            }
            return false;
        }


        public DataTable UpdateExsistCourse()
        {
            string sql1 = "select * from [Courses] where ID='" + this.ID + "'";
            DataTable f = DBFunctions.SelectFromTable(sql1);
            if (f.Rows.Count > 0)
            {
                return f;
            }
            else
            {
                return null;
            }


        }

        public void UpdateCourses()
        {
            // Courses c1 = new Courses(Session["IdCourse"].ToString());

            string sql = " UPDATE Courses SET [Mandatory] = '" + this.Mandatory + "'  where [ID]= '" + this.ID + "'";
            DBFunctions.ChangTable(sql);
        }

    }

    
}