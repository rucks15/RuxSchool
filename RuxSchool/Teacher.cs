using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuxSchool
{
    public class Teacher
    {
        #region Statics
        private static int lastTID = 1;
        #endregion

        #region Constructor
        public void TeacherID()
        {
            TID = lastTID++;
        } 
        #endregion

        #region Properties
        //*Unique ID generated for the teacher
        public int TID { get; private set; }
        //*Name of the staff
        public string Name { get; set; }
        //*Date of birth of the staff
        public string DOB { get; set; }
        //*Degree/graduate details of the staff
        public string Qualification { get; set; }
        //*Working experience i.e Number of years since started to work 
        public int TeachingExperience { get; set; }
        //*Basic payment of the staff
        public decimal basicpay { get; private set; }
        //*Pay that is inclusive of all additional payments
        public decimal netpay { get; private set; }
        //*Additional payments if any
        public decimal addpay { get; private set; }
        //*Number of working days of the staff
        public int workingDays { get; private set; }
        #endregion

        #region Methods
        public int Attendance(int days)
        {
            workingDays += days;
            return workingDays;
        }
        public decimal calculatePay(decimal basicAmount,decimal amount)
        {
            basicpay = basicAmount;
            addpay = amount;
            netpay = basicpay + amount;
            return netpay;
        }
        #endregion
    }
}
