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

        // كود اضافة الزبائن 
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
    }
    
}