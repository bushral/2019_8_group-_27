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
        public int  Credits;
        public string Department;
        public string Mandatory;
        public string Year;
        public string Semester;

        public Courses(string id) { this.ID = id; }

        public Courses(string id,string d,string h,string name,int credit,string depart,string mand,string y,string semster)
        {
            this.ID = id;
            this.Day = d;
            this.Hour = h;
            this.CourseName = name;
            this.Credits = credit;
            this.Mandatory = mand;
            this.Year = y;
            this.Semester = semster;

            

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
                string sql = " INSERT INTO [Courses] ([ID],[Day],[Hour],[CourseName],[Credits],[Department],[Mandatory],[Year],[Semester])";
                string sql2 = "VALUES ('" + this.ID + "','" + this.Day + "','" + this.Hour + "','" + this.CourseName + "','" + this.Credits + "','" + this.Department + "','" + this.Mandatory + "','"+this.Year+"','"+this.Semester+"')";
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

    }

    
}