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
                Console.WriteLine("Please select any option:");
                Console.WriteLine("1.Enter Student Details");
                Console.WriteLine("2.Enter Teacher Details");
                Console.WriteLine("3.View All Teacher Details");
                Console.WriteLine("4.Exit");
                Console.WriteLine("5.Print All");
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
                        Console.WriteLine("Enter the number of working days:");
                        days = int.Parse(Console.ReadLine());
                        student_details.Attendance(days);
                        break;
                    case "2":
                        Console.WriteLine("Enter the Teacher Name:");
                        string TName = Console.ReadLine();
                        Console.WriteLine("Enter the DOB(dd/MM/yyyy):");
                        string TDOB = Console.ReadLine();
                        Console.WriteLine("Enter the Qualification:");
                        string qualification = Console.ReadLine();
                        Console.WriteLine("Enter the working experience(number of years):");
                        int exp = int.Parse(Console.ReadLine());
                        var teacher_details = School.EnterProfile(TName, TDOB, qualification, exp);
                        Console.WriteLine("Enter the number of working days:");
                        int wdays = int.Parse(Console.ReadLine());
                        teacher_details.Attendance(wdays);
                        Console.WriteLine("Enter the basic pay of the staff:");
                        int bpay = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the additional payments:");
                        int addpay = int.Parse(Console.ReadLine());
                        teacher_details.calculatePay(bpay, addpay);
                        Console.WriteLine($"Total Pay:{teacher_details.netpay}:C");
                        break;
                    case "3":
                        School.AllTeacherDetails();
                        break;
                    case "5":
                        School.PrintAllStudent();
                        break;

                    case "4":
                        return;



                }
            }
        }

    }
}