using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System. Data;
using System.Data.OleDb;
using System.Configuration;

namespace WebApplication1 
{
    class DBFunctions
    {

        public DBFunctions()
        {
        }



        /*Function takes the name of the database file and constructs an object of the class type 
         * OleDbConnection 
         * Open channel of communication with the database file and returns this instance
         * */
        public static OleDbConnection GenerateConnection()
        {
            OleDbConnection conObj = new OleDbConnection();//متغير لفتح الرابط
            // the fil need to be on the desktop
            conObj.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Source\Repos\example\project2018yos\Project2018\project2018yos\DataApp\DatabaseProject2018.accdb;Persist Security Info=False;"; // نعطيه الرابط
            conObj.Open();//فتح الرابط
            return conObj;

        }
        /*
         *Action receives the file name of the database and returns the query should perform 
         */
        public static DataTable SelectFromTable(string sqlString) // ترجع جدول
        {
            OleDbConnection conObj = GenerateConnection(); 
            OleDbDataAdapter daObj = new OleDbDataAdapter(sqlString, conObj);
            DataSet dsUser = new DataSet();
            daObj.Fill(dsUser);
            DataTable dt = dsUser.Tables[0];
            conObj.Close();
            return dt;
        }
        /*
         * Action receives the file name of the database and returns the query with the changes are needed to query
         * */
        public static void ChangTable(string sqlString)// تغير الجدول او تحديث
        {
            OleDbConnection conObj = GenerateConnection();
            OleDbCommand cmd = new OleDbCommand(sqlString, conObj);
            cmd.ExecuteNonQuery();
            conObj.Close();
        
        }
        /*
         * This returns the query result as a numeric value of type real number
         * Action is intended to carry out the calculation as average, maximum, stock and more
        */
        public static double CalcSqlFunction(string sqlString) //لم نستعملها فالبحث
        {
            DataTable dt = DBFunctions.SelectFromTable(sqlString);
            return double.Parse(dt.Rows[0][0].ToString());
        }
    }

}

