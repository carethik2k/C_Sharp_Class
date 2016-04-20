using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ListReference
{
    class Program
    {
        //Accept ID and Name of 5 students and print it in the end
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

            foreach (Student student in listStudent)
            {
                if (student.Name == "Karthik")
                {
                    Console.WriteLine(string.Format("ID: {0} Name: {1}", student.StudentId, student.Name));
                }
            }
        }
    }
}
