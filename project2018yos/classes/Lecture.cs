using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1;

namespace project2018yos
{
    public class Lecture
    {
        public string ID;
        public string Name;
        public string LastName;
        public string IdCourse;
        public string Department;


        public Lecture(string Name,string ID)
        {
           
            this.Name = Name;
            this.ID = ID;
        }

        public Lecture(string ID) { this.ID = ID; }

        public bool logIn()
        {
            //string sql = " select * from Lecture where";
            //string sql1 = " Name='" + this.Name + "' and ID='" + this.ID + "'";
            string sql = " select Name,ID from [Lecture] where Name='" + this.Name + "'and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            //DataTable dt = DBFunctions.SelectFromTable(sql + sql1);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // בודק אם מרצה קיים
        public bool checkIfLectureExsist()
        {
            string sql = "select *from [Lecture] where ID ='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;

            return false;
        }
        //שומר תז בטבלה
        public DataTable sessionId()
        {
            string sql = "select ID From [Lecture] where Name ='" + this.Name + "'and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }

        public DataTable sessionDepartment()
        {
            string sql = "select Department From [Lecture] where Name ='" + this.Name + "'and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }

    }
}