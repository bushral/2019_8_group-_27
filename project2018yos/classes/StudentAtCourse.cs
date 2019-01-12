using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1;

namespace project2018yos.classes
{
    public class StudentAtCourse
    {
        public string Id_Course;
        public string Id_Student;


        public StudentAtCourse(string iCourse,string iStudent) { this.Id_Course = iCourse; this.Id_Student = iStudent; }


        public bool CheckExist()
        {
            string sql = "Select * From [StudentAtCourse] Where Id_Course='" + this.Id_Course + "' and Id_Student='"+ this.Id_Student+"'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public bool insertCourseForStudent()
        {

            if (!CheckExist())
            {
                string sql = " INSERT INTO [StudentAtCourse] ([Id_Course],[Id_Student])";
                string sql2 = "VALUES ('" + this.Id_Course + "','" + this.Id_Student+ "')";
                DBFunctions.ChangTable(sql + sql2);
                return true;
            }

            return false;

        }


        public bool DeleteCourseForStudent()
        {
            if (CheckExist())
            {
                string x = "Delete From [StudentAtCourse] Where Id_Course='" + this.Id_Course + "' and Id_Student='"+this.Id_Student+"'";
                DBFunctions.ChangTable(x);
                return true;
            }
            return false;
        }
    }
}