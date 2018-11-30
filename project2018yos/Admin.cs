using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1;

namespace project2018yos
{
    public class Admin
    {
        public string ID;
        public string UserName;
        public string FirstName;
        public string LastName;
        public string Email;




        public Admin( string user, string Id)
        {
          
            this.UserName = user;
            this.ID = Id;
        }

        public bool logIn()
        {
            string sql = " select * from Admin where";
            string sql1 = " UserName='" + this.UserName + "' and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql + sql1);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // كود اضافة الزبائن 
        public bool checkIfAdminExsist()
        {
            string sql = "select *from [Admin] where ID ='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;

            return false;
        }

        public DataTable sessionId()
        {
            string sql = "select ID From [Admin] where UserName ='" + this.UserName + "'and ID='" + this.ID + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }





    }
}