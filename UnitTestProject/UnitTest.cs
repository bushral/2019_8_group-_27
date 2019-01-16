using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using project2018yos;
using project2018yos.classes;
using WebApplication1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        //This Block Tests Login
        #region Test Login

        /// <summary>
        /// Login With Invalid Username Or ID
        /// </summary>
        [TestMethod]
        public void LoginWithInvalidUsernameOrID()
        {
            //Random Username And ID
            //Does'nt Exist in Any Table Of Users
            string Username = "ram23";
            string ID = "443335555";

            //Create An Instance From Admin Table, And Try to Login
            Admin adminRole = new Admin(Username, ID);
            bool result = adminRole.logIn();

            //We Should Get False, The Information Doesn't Exist in System
            Assert.AreEqual(result, false);
        }

        /// <summary>
        /// Login With Valid Username And ID From Admin Table As Admin
        /// </summary>
        [TestMethod]
        public void LoginWithValidUsernameAndID()
        {
            //Username And ID Exist in Admin Table
            string Username = "ram23";
            string ID = "443334444";

            //Create An Instance From Admin Table, And Try to Login
            Admin adminRole = new Admin(Username, ID);
            bool result = adminRole.logIn();

            //We Should Get True, The Information Exists in Admin Table
            Assert.AreEqual(result, true);

        }

        /// <summary>
        /// Login With Valid Username And ID from Admin Table
        /// But As Student
        /// </summary>
        [TestMethod]
        public void LoginWithValidUsernameAndIDButNotAdmin()
        {
            //Username And ID Exist in Admin Table
            string Username = "ram23";
            string ID = "443334444";

            //Create An Instance From Students Table, And Try to Login
            Students studentRole = new Students(Username, ID);
            bool result = studentRole.logIn();

            //We Should Get False, The Information Exists in Admin Table, But Not in Students Table
            Assert.AreEqual(result, false);

        }

        #endregion

        //This Block Tests Courses
        #region Test Courses

        /// <summary>
        /// Add New Course to the Database
        /// </summary>
        [TestMethod]
        public void AddNewCourse()
        {
            //Create New Object From DepartmentCourses Class
            DepartmentCourses c = new DepartmentCourses("software", "3", "1", "Course 1", "2212", "Sunday", "8", "13", "3", "Yes", "1111", "10", "20", "GG");

            //Insert the Course to the Database
            bool result = c.insertCourse();

            //We Should Get True Because The Course Doesn't Exist
            Assert.AreEqual(result, true);
        }

        /// <summary>
        /// Add Existing Course to the Database
        /// </summary>
        [TestMethod]
        public void AddExistingCourse()
        {
            //Create New Object From DepartmentCourses Class
            DepartmentCourses c = new DepartmentCourses("software", "3", "1", "Course 1", "2212", "Sunday", "8", "13", "3", "Yes", "1111", "10", "20", "GG");
            
            //Insert The Course to the Database
            bool result = c.insertCourse();

            //We Should Get False Because The Course Exists
            Assert.AreEqual(result, false);
        }

        #endregion

        //This Block Tests Students
        #region Test Students

        /// <summary>
        /// Add New Student to the Database
        /// </summary>
        [TestMethod]
        public void AddNewStudent()
        {
            //Create New Object From Student Class
            Students s = new Students("555", "Stud 1", "Student", "2", "1", "Software");

            //Insert the Student to the Database
            bool result = s.insertStudent();

            //We Should Get True Because The Student Doesn't Exist
            Assert.AreEqual(result, true);
        }

        /// <summary>
        /// Add Existing Student to the Database
        /// </summary>
        [TestMethod]
        public void AddExistingStudent()
        {
            //Create New Object From Student Class
            Students s = new Students("555", "Stud 1", "Student", "2", "1", "Software");

            //Insert The Student to the Database
            bool result = s.insertStudent();

            //We Should Get False Because The Student Exists
            Assert.AreEqual(result, false);
        }

        #endregion

        //This Block Tests Course Registeration for Lecturer
        #region Get From Database

        [TestMethod]
        public void GetExistDepartmentByCourseID()
        {
            //Create Query And Get Data From Database
            string query = "select Department from [DepartmentCourses] where IdCourse='SoftArchi'";   
            string department = GetDataFromDatabase(query, "Department");

            bool result = department.ToLower().Equals("software");

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void GetDoesntExistDepartmentByCourseID()
        {
            //Create Query And Get Data From Database
            string query = "select Department from [DepartmentCourses] where IdCourse='123'";
            string department = GetDataFromDatabase(query, "Department");

            bool result = department.ToLower().Equals("software");

            Assert.AreEqual(result, false);
        }

        #endregion

        //Help Function
        #region Help Functions

        /// <summary>
        /// Get First Row From Database With The Given Column Name
        /// </summary>
        /// <param name="query"></param>
        /// <param name="requiredColumn"></param>
        /// <returns></returns>
        public string GetDataFromDatabase(string query, string requiredColumn)
        {
            DataTable dt2 = DBFunctions.SelectFromTable(query);
            foreach (DataRow row in dt2.Rows)
            {
                return row[requiredColumn].ToString();
            }

            return string.Empty;
        }

        #endregion

    }
}
