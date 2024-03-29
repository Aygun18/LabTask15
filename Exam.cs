using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask15
{
	internal class Exam
	{
		public string[] ExamName;
		public int[] ExamPoint;

        public Exam(string[] examname,int[] exampoint)
        {
            ExamName = examname;
            ExamPoint = exampoint;
        }
    }
}
