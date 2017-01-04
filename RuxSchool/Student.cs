using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuxSchool
{
    
    public enum  Syllabus
    {
        StateBoard,
        CBSE,
        ICSE
    }
    /// <summary>
    /// This class has student details
    /// </summary>
    public class Student
    {
        #region statics
        private static int lastRollNumber = 1;
        #endregion

        #region properties
        //Unique roll number of the student 
        public int RollNumber { get; private set; }
        //Name of the student 
        public string Name { get; set; }
        //Contact number of the student
        public string EmailID { get; set; }
        //Date of birth of the student
        public string DOB { get; set; }
        /// <summary>
        /// Choice of syllabus the student prefer to study from the enum datatype 'Syllabus'
        /// </summary>
        public Syllabus Medium { get; set; }
        //Standard in which the student is studying in the current year
        public string Standard { get; set; }
        // Number of working days of the student till date
        public int WorkingDays = 0;
        // Total marks obtained by the student in tests.
        public int Marks { get;  set; }
        #endregion

        #region constructor
        /// <summary>
        /// To generate roll number automatically
        /// </summary>
        public Student ()
        {
            RollNumber = lastRollNumber++;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Attendance of the student is updated
        /// </summary>
        /// <param name="days">Number of working days</param>
        /// <returns>Total working days till last update</returns>
        public int Attendance(int days)
        {
            WorkingDays += days;
            return WorkingDays;
        }
        /// <summary>
        /// Total marks of the tests is calculated
        /// </summary>
        /// <param name="M1">Mark of subject1</param>
        /// <param name="M2">Mark of subject2</param>
        /// <param name="M3">Mark of subject3</param>
        /// <param name="M4">Mark of subject4</param>
        /// <returns>Total marks of all subjects</returns>
        public int Result(int M1,int M2,int M3,int M4)
        {
            Marks = M1 + M2 + M3 + M4;
            return Marks;
        }
        #endregion
    }
}
