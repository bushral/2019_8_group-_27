
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1;

namespace project2018yos
{
    public class Students
    {
        string ID;
        string Name;
        string LastName;
        string Year;
        string semester;
        string Department;
        public Students(string id,string n,string last,string y,string sem,string dep)
        {
            this.ID = id;
            this.Name = n;
            this.LastName = last;
            this.Year = y;
            this.semester = sem;
            this.Department = dep;

        }

        public Students(string Id) { this.ID = Id; }
        public Students(string Name,string Id)
        {
            this.Name = Name;

            this.ID = Id;
        }

        public bool logIn()
        {
            //string sql = " select * from Students where";
            //string sql1 = "Name='" + this.Name + "' and ID='" + this.ID + "'";
            string sql=" select Name,ID from [Students] where Name='"+this.Name+"'and ID='"+this.ID+"'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // בודק האם סטודנט קיים או לא
        public bool checkIfStudentExsist()
        {
            string sql = "select * from [Students] where ID ='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;

            return false;
        }

        public DataTable sessionId()
        {
            string sql = "select ID from [Students] where Name ='" + this.Name + "'and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }

        public DataTable sessionDepartment()
        {
            string sql = "select Department from [Students] where Name ='" + this.Name + "'and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }
        public DataTable sessionYear()
        {
            string sql = "select Year from [Students] where Name ='" + this.Name + "'and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }
        public DataTable sessionSemster()
        {
            string sql = "select semester from [Students] where Name ='" + this.Name + "'and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }

        public bool insertStudent()
        {

            if (!checkIfStudentExsist())
            {
                string sql = " INSERT INTO [Students] ([ID],[Name],[LastName],[Year],[semester],[Department])";
                string sql2 = "VALUES ('" + this.ID + "','" + this.Name + "','" + this.LastName + "','" + this.Year + "','" + this.semester + "','" + this.Department + "')";
                DBFunctions.ChangTable(sql + sql2);
                
                return true;
            }

            return false;

        }
    }
    
}