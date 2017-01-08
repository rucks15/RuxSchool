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
        private static List<Teacher> TotalTeachers = new List<Teacher>();
        #endregion

        public static Student CreateProfile(string name,string dob,Syllabus medium, string emailId,string standard)
        {
            var student_profile = new Student();
            student_profile.Name = name;
            student_profile.DOB = dob;
            student_profile.Medium = medium;
            student_profile.EmailID = emailId;
            student_profile.Standard = standard;
            student_list.Add(student_profile);
            return student_profile;
        }
        public static Teacher EnterProfile(string name,string dob,string qualification,int teaching_experience)
        {
            var teacher_profile = new Teacher();
            teacher_profile.Name = name;
            teacher_profile.DOB = dob;
            teacher_profile.Qualification = qualification;
            teacher_profile.TeachingExperience = teaching_experience;
            TotalTeachers.Add(teacher_profile);
            return teacher_profile;
        }


        public static void PrintAllStudent()
        {
            foreach(var student_profile in student_list)
            {
                Console.WriteLine($"Name:{student_profile.Name},Roll Number:{student_profile.RollNumber},Standard:{student_profile.Standard}");
            }
        }

        public static void AllTeacherDetails()
        {
            foreach(var teacher_profile in TotalTeachers)
            {
                Console.WriteLine($"Name:{teacher_profile.Name}, DateOfBirth : {teacher_profile.DOB}, BasicPay:{teacher_profile.basicpay},NetPay:{teacher_profile.netpay}");
            }
        }
       

    }
}
