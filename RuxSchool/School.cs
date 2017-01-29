using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuxSchool
{
    public static class School
    {
       
        

        public static Student CreateProfile(string name,string dob,Syllabus medium, string emailId,string standard)
        {
            var student_profile = new Student();
            using (var db = new StudentDB())
            {   
                student_profile.Name = name;
                student_profile.DOB = dob;
                student_profile.Medium = medium;
                student_profile.EmailID = emailId;
                student_profile.Standard = standard;
                db.StudentDetails.Add(student_profile);
                db.SaveChanges();
            }

            return student_profile;
        }

        public static Student GetTheStudent(int rollnumber)
        {
            var db = new StudentDB();
            return db.StudentDetails.Where(a => a.RollNumber == rollnumber).FirstOrDefault();
        }

        public static void Attendance(int rollnumber,int days)
        {
            var student = School.GetTheStudent(rollnumber);
            if (student != null)
            {
                student.Attendance(days);
            }
        }
        
        public static Student GPACalculation(decimal m1,decimal m2,decimal m3,decimal m4,int rno)
        {
            var student = School.GetTheStudent(rno);

            using (var db = new StudentDB())
            {
                decimal result = student.Result(m1, m2, m3, m4);
                var examResult = new ExamResults();
                examResult.RollNumber = rno;
                examResult.exam_title = "Trimester";
                examResult.exam_date = DateTime.Now;
                examResult.gpa = result;
                db.Results.Add(examResult);
                db.SaveChanges();
            }
                return student;
            
        }

        public static void PrintAllStudent()
        {
            using (var db = new StudentDB())
            {
                foreach (var student_profile in db.StudentDetails)
                {
                    Console.WriteLine($"Name:{student_profile.Name},Roll Number:{student_profile.RollNumber},Standard:{student_profile.Standard},Attendance :{student_profile.WorkingDays},GPA:{student_profile.GPA}");
                }
            }
        }

        public static Student RetrieveStudentProfile(int rollnumber)
        {
            using (var db = new StudentDB())
            {
                return db.StudentDetails.Where(a => a.RollNumber == rollnumber).First();
            }
        }

        public static ExamResults RetrieveMarks(int examnumber)
        {
            using (var db = new StudentDB())
            {
                return db.Results.Where(a => a.exam_number == examnumber).First();
            }
        }


    }
}
