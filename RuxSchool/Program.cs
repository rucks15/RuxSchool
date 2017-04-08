using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuxSchool
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("   Welcome to Rux School");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            while (true)
            {
                Console.WriteLine("Enter the user type from below:");
                Console.WriteLine("1.Student");
                Console.WriteLine("2.Teacher");
                Console.WriteLine("3.Exit");
                var usertype = Convert.ToInt32(Console.ReadLine());
                while (usertype == 1)
                {

                    bool shouldExitLoop = false;
                    Console.WriteLine("Enter any option below:");
                    Console.WriteLine("1.View your profile");
                    Console.WriteLine("2.View exam results");
                    Console.WriteLine("3.Exit");

                    var opt = Console.ReadLine();
                    switch (opt)
                    {
                        case "1":
                            Console.WriteLine("Enter the roll number:");
                            int rollnu = Convert.ToInt32(Console.ReadLine());
                            //var getProfile = School.RetrieveStudentProfile(rollnu);
                            //Console.WriteLine($"Name:{getProfile.Name}\nRollNumber:{getProfile.RollNumber}\nDateOfBirth:{getProfile.DOB}\nEmailID:{getProfile.EmailID}\nStandard:{getProfile.Standard}\nMedium:{getProfile.Medium}");
                            break;
                        case "2":
                            Console.WriteLine("Enter the roll number:");
                            int rollno = Convert.ToInt32(Console.ReadLine());
                            var checkrollnumber = School.GetTheStudent(rollno);
                            if(checkrollnumber==null)
                            {
                                Console.WriteLine("Sorry,this roll number you entered does not exist");
                            }
                            else
                            {
                                Console.WriteLine("Enter the exam code/exam number:");
                                int examno = Convert.ToInt32(Console.ReadLine());
                                var studentResults = School.RetrieveMarks(examno);
                                Console.WriteLine($"ExamTitle:{studentResults.exam_title}\nExamDate:{studentResults.exam_date}\nGPA:{studentResults.gpa}");
                            }
                            break;
                        case "3":
                            shouldExitLoop = true;
                            break;
                    }

                    if (shouldExitLoop)
                    {
                        break;
                    }
                }

                while (usertype == 2)
                {
                    bool shouldExitLoop = false;

                    Console.WriteLine("Please select any option:");
                    Console.WriteLine("1.Enter Student Details");
                    Console.WriteLine("2.View all student details");
                    Console.WriteLine("3.Enter attendance");
                    Console.WriteLine("4.Enter marks");
                    Console.WriteLine("5.Exit");

                    var option = Console.ReadLine();


                    switch (option)
                    {

                        case "1":
                            int days;
                            Console.WriteLine("Enter the student name :");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter Date of Birth:");
                            string DOB = Console.ReadLine();
                            var Medium = Syllabus.CBSE;
                            Console.WriteLine("Enter the EmailID:");
                            string EmailID = Console.ReadLine();
                            Console.WriteLine("Enter the standard:");
                            string Standard = Console.ReadLine();
                            var student_details = School.CreateProfile(Name, DOB, Medium, EmailID, Standard);
                            Console.WriteLine($"Name:{student_details.Name},Roll Number : {student_details.RollNumber }, Standard:{student_details.Standard},Date of Birth : {student_details.DOB },Medium : {student_details.Medium },EmailID:{student_details.EmailID }");

                            break;


                        case "2":
                            School.PrintAllStudent();
                            break;
                        case "3":
                            Console.Write("Enter the Roll number:");
                            int rollno = Convert.ToInt32(Console.ReadLine());
                            var detail = School.GetTheStudent(rollno);
                            if (detail == null)
                            {
                                Console.WriteLine("Roll number does not exist");
                            }
                            else
                            {
                                Console.WriteLine("Enter the number of working days:");
                                days = Convert.ToInt32(Console.ReadLine());
                                School.Attendance(rollno, days);
                            }
                            break;
                        case "4":
                            Console.Write("Enter the Roll number:");
                            int rollnu = Convert.ToInt32(Console.ReadLine());
                            var getdetail = School.GetTheStudent(rollnu);
                            if (getdetail == null)
                            {
                                Console.WriteLine("Roll number does not exist");
                            }
                            else
                            {
                                Console.WriteLine("Enter the marks for");
                                Console.Write("Mark1:");
                                decimal m1 = Convert.ToDecimal(Console.ReadLine());
                                Console.Write("Mark2:");
                                decimal m2 = Convert.ToDecimal(Console.ReadLine());
                                Console.Write("Mark3:");
                                decimal m3 = Convert.ToDecimal(Console.ReadLine());
                                Console.Write("Mark4:");
                                decimal m4 = Convert.ToDecimal(Console.ReadLine());
                                var resultStudent = School.GPACalculation(m1, m2, m3, m4, rollnu);
                                Console.Write($"GPA:{resultStudent.GPA}");

                            }
                            break;

                        case "5":
                            shouldExitLoop = true;
                            break;



                    }
                    if(shouldExitLoop)
                    {
                        break;
                    }
                }
                if(usertype==3)
                {
                    return;
                }
            }
        }

    }
}