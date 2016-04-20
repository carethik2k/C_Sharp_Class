using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCount = 3;
            List<Student> listStudent = new List<Student>();
            for (int i = 0; i < 3; i++)
            {
                Student objStudent = new Student();
                Console.Write("Please enter the Student ID: ");
                objStudent.StudentId = Int32.Parse(Console.ReadLine());
                Console.Write("Please enter the Student Name: ");
                objStudent.Name = Console.ReadLine();
                listStudent.Add(objStudent);
            }

            //Query to get by name - only first occurence
            //Student student = listStudent.First(x => x.Name == "Karthik");
            Student student = listStudent.FirstOrDefault(x => x.Name == "Karthik");

            if(student != null)
                Console.WriteLine(string.Format("ID: {0} Name: {1}", student.StudentId, student.Name));

            //Query to get by name - all occurences
            //IEnumerable<Student> stdList = listStudent.Where(x => x.Name == "Karthik");
            IEnumerable<Student> stdList = listStudent.Where(x => x.StudentId >= 20);
            foreach (var student1 in stdList)
            {
                Console.WriteLine(string.Format("ID: {0} Name: {1}", student1.StudentId, student1.Name));
            }

            listStudent.Sort((std1, std2) => std1.Name.CompareTo(std2.Name));
            listStudent.ForEach(x=>Console.WriteLine(x.Name));
        }
    }
}
