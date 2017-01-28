using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuxSchool
{
    public static class School
    {
       /// <summary>
       /// To store student details in a list
       /// </summary>
        #region Fields
        private static List<Student> student_list = new List<Student>();
        
        #endregion

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
            return new Student();
        }
        


        public static void PrintAllStudent()
        {
            foreach(var student_profile in student_list)
            {
                Console.WriteLine($"Name:{student_profile.Name},Roll Number:{student_profile.RollNumber},Standard:{student_profile.Standard}");
            }
        }



    }
}
