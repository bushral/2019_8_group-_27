using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1;

namespace project2018yos.classes
{
    public class LectureOfCourse
    {


        public string Id_Course;
        public string Id_lecture;


        public LectureOfCourse(string iCourse, string iLec) { this.Id_Course = iCourse; this.Id_lecture = iLec; }


        public bool CheckExist()
        {
            string sql = "Select * From [LectureOfCourse] Where Id_Course='" + this.Id_Course + "' and Id_Lecture='" + this.Id_lecture + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public bool insertCourseForLecture()
        {

            if (!CheckExist())
            {
                string sql = " INSERT INTO [LectureOfCourse] ([Id_Course],[Id_Lecture])";
                string sql2 = "VALUES ('" + this.Id_Course + "','" + this.Id_lecture + "')";
                DBFunctions.ChangTable(sql + sql2);
                return true;
            }

            return false;

        }


        public bool DeleteCourseForLecture()
        {
            if (CheckExist())
            {
                string x = "Delete From [LectureOfCourse] Where Id_Course='" + this.Id_Course + "' and Id_Lecture='" + this.Id_lecture + "'";
                string s = "Update DepartmentCourses SET Lecture='' and LectureName='' where Id_Course='" + this.Id_Course + "'";
                DBFunctions.ChangTable(x+s);
                return true;
            }
            return false;
        }
    }
}
