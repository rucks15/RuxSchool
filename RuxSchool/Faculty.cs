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
        #region Properties
        //Denotes Faculty ID
        public string Name { get; set; }
      //Denotes Employee ID
        public int Empid { get; set; }
        //Faculty Qualification
        public string Qualification { get; set; }
        //E-mail address of the faculty
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        //Phone number of the faculty
        public string phone { get; set; }

        #endregion

        
    }
}
