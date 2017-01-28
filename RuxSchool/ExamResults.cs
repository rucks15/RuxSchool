using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuxSchool
{
    public class ExamResults
    {
        #region properties
        [ForeignKey("student_detail")]
        public int RollNumber { get; set; }

        public virtual Student student_detail{get;set;}

        public string exam_title { get; set; }

        public string exam_date { get; set; }
 
        public decimal gpa { get; private set; }

        public decimal percentage { get; private set; }
        #endregion

    }
}
