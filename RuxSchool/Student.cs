using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        

        #region properties
        [Key]
        //Unique roll number of the student 
        public int RollNumber { get; set; }
        //Name of the student 
        public string Name { get; set; }
        //Contact number of the student
        [DataType(DataType.EmailAddress)]
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
        public int WorkingDays { get; set; }
        // Total marks obtained by the student in tests.
        public decimal Marks { get;  set; }
        //Average percentage
        public decimal GPA { get; set; }
        public virtual ICollection<ExamResults> Results { get; set; }
        #endregion

        

        #region Methods
       
        /// <summary>
        /// Attendance of the student is updated
        /// </summary>
        /// <param name="days">Number of working days</param>
        /// <returns>Total working days till last update</returns>
        public void Attendance(int days)
        {
            using (var db = new StudentDB())
            {
                var original = db.StudentDetails.Where(a => a.RollNumber == this.RollNumber).First();
                var update = original;
                WorkingDays += days;
                update.WorkingDays = WorkingDays;
                db.Entry(original).CurrentValues.SetValues(update);
                db.SaveChanges();
                //return WorkingDays;
            }
        }
        /// <summary>
        /// Total marks of the tests is calculated
        /// </summary>
        /// <param name="M1">Mark of subject1</param>
        /// <param name="M2">Mark of subject2</param>
        /// <param name="M3">Mark of subject3</param>
        /// <param name="M4">Mark of subject4</param>
        /// <returns>Total marks of all subjects</returns>
        public decimal Result(decimal M1,decimal M2,decimal M3,decimal M4)
        {
            using (var db = new StudentDB())
            {
                var original = db.StudentDetails.Where(a => a.RollNumber == this.RollNumber).FirstOrDefault();
                var updated = original;
                Marks = M1 + M2 + M3 + M4;
                GPA = Marks / 4;
                updated.Marks = Marks;
                updated.GPA = GPA;
                db.Entry(original).CurrentValues.SetValues(updated);
                db.SaveChanges();
                return GPA;
            }
        }
        #endregion
    }
}
