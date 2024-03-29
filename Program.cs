using System.Net.Http.Headers;

namespace LabTask15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student student1 = new Student("Ali", "Aliyev", "Kompüter elmleri",new int[] {32,15,24,46,56});
			Student student2 = new Student("Murad", "Muradov", "Kimya", new int[] { 32, 15, 24, 46, 56});
			Student student3 = new Student("Nigar", "Aliyeva", "Biologiya",new int[] {32, 15, 24, 46, 56});

			Exam exam = new Exam(new string[] { "Informatika", "Biologiya", "Kimya","Fizika","Riyaziyyat"},new int[] {15,24,45,56,67});

			student1.CheckExam(exam);
			student1.StudentInfo(exam);
            Console.WriteLine("----------------------------");
            student2.CheckExam(exam);
			student2.StudentInfo(exam);
			Console.WriteLine("----------------------------");
			student3.CheckExam(exam);
			student3.StudentInfo(exam);
		}
	}
}