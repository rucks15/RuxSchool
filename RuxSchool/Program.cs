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
                var usertype = Convert.ToInt32(Console.ReadLine());
                if (usertype == 1)
                {
                    Console.WriteLine("Enter any option below:");
                    Console.WriteLine("1.View your profile");
                    Console.WriteLine("2.View exam results");
                    Console.WriteLine("3.Exit");

                    var opt = Console.ReadLine();
                    switch (opt)
                    {
                        case "1":

                            break;
                        case "2":
                            break;
                        case "3":
                            return;
                        default:
                            break;
                    }
                }
                else
                {


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
                            var detail=School.GetTheStudent(rollno);
                            if (detail == null)
                            {
                                Console.WriteLine("Roll number does not exist");
                            }
                            else
                            {
                                Console.WriteLine("Enter the number of working days:");
                                days = Convert.ToInt32(Console.ReadLine());
                                detail.Attendance(days);
                            }
                            break;

                        case "5":
                            return;



                    }
                }
            }
        }

    }
}