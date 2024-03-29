using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask15
{
	internal class Student
	{
		public string Name;
		public string Surname;
		public string Faculty;
		public int[] ImtahanadekBal;
		public char[] Result=new char[5];

		public Student(string name, string surname, string faculty, int[] imtahanadekbal)
		{
			Name = name;
			Surname = surname;
			Faculty = faculty;
			ImtahanadekBal = imtahanadekbal;

		}
		public void CheckExam(Exam exam)
		{
			for (int i = 0; i < ImtahanadekBal.Length; i++)
			{
				char netice = 'F';
				if (exam.ExamPoint[i]>17)
				{
					int sum = ImtahanadekBal[i] + exam.ExamPoint[i];

					if (sum > 90)
					{
						netice = 'A';
					}
					else if (sum > 80)
					{
						netice = 'B';
					}
					else if (sum > 70)
					{
						netice = 'C';
					}
					else if (sum > 60)
					{
						netice = 'D';
					}
					else if (sum > 50)
					{
						netice = 'E';
					}
					else
					{
						netice = 'F';
					}
				}
				Result[i] = netice;
				
			}
		}
		public void StudentInfo(Exam exam)
		{
			Console.WriteLine($"Name: {Name} Surname: {Surname} Facutly: {Faculty}");
			for (int i = 0; i < ImtahanadekBal.Length; i++)
			{
				Console.WriteLine("ImtahadekBal: "+ ImtahanadekBal[i]);
				Console.WriteLine("ImtahanBali: "+ exam.ExamPoint[i]);
				Console.WriteLine("Netice: " +Result[i]);
            }

		}


	}
}
