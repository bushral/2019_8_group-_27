using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1;

namespace project2018yos.classes
{
    public class DepartmentCourses
    {
        public string Department;
        public string Year;
        public string Semster;
        public string CourseName;
        public string IdCourse;
        public string Day;
        public string HourStart;
        public string HourEnd;
        public string Credits;
        public string Mandatory;
        public string Lecture;
        public string RegisteredStudents;
        public string MaxStudent;
        public string LectureName;

        public DepartmentCourses(string lecId,string lecName,string idC,string Dep)
        {
            this.Lecture = lecId;
            this.LectureName = lecName;
            this.IdCourse = idC;
            this.Department = Dep;
        }
        
        public DepartmentCourses(string man, string s) { this.IdCourse = man; this.Mandatory = s; }
        public DepartmentCourses(string RegisteredStudents,string max,string id) { this.RegisteredStudents = RegisteredStudents; this.MaxStudent = max; this.IdCourse = id; }
        public DepartmentCourses(string d,string y,string s,string cn,string ic,string day,string hs,string he,string cre,string mand, string lec,string rs,string ms,string ln)
        {
            this.Department = d;
            this.Year = y;
            this.Semster = s;
            this.CourseName = cn;
            this.IdCourse = ic;
            this.Day = day;
            this.HourStart = hs;
            this.HourEnd = he;
            this.Credits = cre;
            this.Mandatory = mand;
            this.Lecture = lec;
            this.RegisteredStudents = rs;
            this.MaxStudent = ms;
            this.LectureName = ln;
        }

        public DepartmentCourses(string id) { this.IdCourse = id; }


        public bool CheckExist()
        {
            string sql = "Select * From [DepartmentCourses] Where IdCourse='" + this.IdCourse + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public bool insertCourse()
        {

            if (!CheckExist())
            {
                string sql = " INSERT INTO [DepartmentCourses] ([Department],[Year],[Semster],[CourseName],[IdCourse],[Day],[HourStart],[HourEnd],[Credits],[Mandatory],[Lecture],[RegisteredStudents],[MaxStudent],[LectureName])";
                string sql2 = "VALUES ('" + this.Department + "','" + this.Year + "','" + this.Semster + "','" + this.CourseName + "','" + this.IdCourse + "','" + this.Day + "','" + this.HourStart + "','" + this.HourEnd + "','" + this.Credits+ "','" + this.Mandatory + "','"+this.Lecture+"','"+this.RegisteredStudents+"','"+this.MaxStudent+"','"+this.LectureName+"')";
                DBFunctions.ChangTable(sql + sql2);
                return true;
            }

            return false;

        }

        public bool CheckCourseNull()
        {
            string sql = "Select * From [DepartmentCourses] Where IdCourse='" + this.IdCourse + "' and Lecture='null' and LectureName='null'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public void UdpateLectureId()
        {
            string sql = " UPDATE DepartmentCourses SET [Lecture] = '" + this.Lecture + "'  where [IdCourse]= '" + this.IdCourse + "'";
            DBFunctions.ChangTable(sql);
        }
        public void updateLectureName()
        {
            string sql = " UPDATE DepartmentCourses SET [LectureName] = '" + this.LectureName + "'  where [IdCourse]= '" + this.IdCourse + "'";
            DBFunctions.ChangTable(sql);
        }

        public bool DeleteCourse()
        {
            if (CheckExist())
            {
                string x = "Delete From [DepartmentCourses] Where IdCourse='" + this.IdCourse + "'";
                DBFunctions.ChangTable(x);
                return true;

            }
            return false;
        }


        public DataTable UpdateExsistCourse()
        {
            string sql1 = "select * from [DepartmentCourses] where IdCourse='" + this.IdCourse + "'";
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
        public void UpdateRegisteringStudent()
        {
            string sql= "UPDATE DepartmentCourses SET [RegisteredStudents] ='" + this.RegisteredStudents + "'  where MaxStudent='" + this.MaxStudent + "' and [IdCourse]= '" + this.IdCourse + "'";
            DBFunctions.ChangTable(sql);
        }

        public void UpdateRegisteringStud()
        {
            string sql = "UPDATE DepartmentCourses SET [RegisteredStudents] ='" + this.RegisteredStudents + "'  where  [IdCourse]= '" + this.IdCourse + "'";
            DBFunctions.ChangTable(sql);
        }

        public void UpdateRegisteringLecture()
        {
            string sql = "UPDATE DepartmentCourses SET [Lecture] ='" + this.Lecture + "'and [LectureName]='"+this.LectureName+"'  where [IdCourse]= '" + this.IdCourse + "' and Department='"+this.Department+"'";
            DBFunctions.ChangTable(sql);
        }

        public void UpdateCourses()
        {
            // Courses c1 = new Courses(Session["IdCourse"].ToString());

            string sql = " UPDATE DepartmentCourses SET [Mandatory] = '" + this.Mandatory + "'  where [IdCourse]= '" + this.IdCourse + "'";
            DBFunctions.ChangTable(sql);
        }

        public DataTable sessionMuchStudent()
        {
            string sql = "select RegisteredStudents From [DepartmentCourses] where IdCourse='" + this.IdCourse + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }
        public DataTable sessionHourStart()
        {
            string sql = "select HourStart From [DepartmentCourses] where IdCourse='" + this.IdCourse + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }

        public DataTable sessionHourEnd()
        {
            string sql = "select HourEnd From [DepartmentCourses] where IdCourse='" + this.IdCourse + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }

        public DataTable sessionMaxStudents()
        {
            string sql = "select MaxStudent From [DepartmentCourses] where  IdCourse='" + this.IdCourse + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            return dt;
        }

    }





    }
