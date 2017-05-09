using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuxSchool
{
    public class Faculty
    {
        #region Statics
        private static int lastEmployeeID = 0;
        #endregion

        #region Constructor
        public Faculty()
        {
            lastEmployeeID += 1;
        }
        #endregion

        #region Properties
        //Name of the Faculty
        public string Name { get; set; }
        //Employee Identification unique number
        public int Empid { get; private set; }
        //Educational Degree of the faculty
        public string Qualification { get; set; }
        //E-mail address of the faculty
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //Phone number of the faculty
        public string Phone { get; set; }
        public int Attendance { get; set; }
        public decimal DA { get; private set; }
        public decimal PF { get; private set; }
        public decimal Base_Salary { get; set; }
        public decimal Final_Salary
        {
            get
            {
                return Final_Salary;
            }
            private set
            {
                Final_Salary = Base_Salary + DA - PF;
            }
        }

        #endregion
    }
  }

