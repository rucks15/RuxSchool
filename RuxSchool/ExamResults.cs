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
        #region statics
        private static int lastexamnumber = 1;
        #endregion

        #region properties
        [ForeignKey("student_detail")]
        public int RollNumber { get; set; }

        public virtual Student student_detail{get;set;}

        [Key]
        public int exam_number { get; private set; }

        public string exam_title { get; set; }

        public DateTime exam_date { get; set; }
 
        public decimal gpa { get; set; }

        
        #endregion

        #region constructor
        public ExamResults()
        {
            exam_number = lastexamnumber++;
        }
        #endregion

        #region Methods
        
        #endregion
    }
}
