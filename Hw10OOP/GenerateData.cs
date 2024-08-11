using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw10OOP
{
    public class GenerateData
    {
        public List<Student> StudentList { get; set; }

        public GenerateData()
        {
            StudentList = new List<Student>();
        }

        public void Create(int studentNumber = 10, int subjectNumber = 3)
        {
            Random r = new Random();

            for (int i = 1; i <= studentNumber; i++)
            {
                var subjectList = new List<Subject>();
                for (int j = 1; j <= subjectNumber; j++)
                {
                    subjectList.Add(new Subject
                    {
                        SubjectID = j,
                        Score = new Test
                        {
                            Test1 = r.Next(1, 51),
                            Test2 = r.Next(1, 51),
                            Test3 = r.Next(1, 51)
                        }
                    });
                }
                StudentList.Add(new Student
                {
                    StudentID = i,
                    StudentSubject = subjectList
                });
            }
        }

        public void Display()
        {
            Console.WriteLine($"{"Id",-5}{"Subject",8}{"Test1",8}{"Test2",8}{"Test3",8}{"Sum",8}{"Net",8}");

            foreach (var student in StudentList)
            {
                Console.Write($"{student.StudentID,-5}");

                for (int j = 0; j < student.StudentSubject.Count; j++)
                {
                    var subject = student.StudentSubject[j];

                    if (j > 0)
                    {
                        Console.Write($"{"",-5}");
                    }

                    Console.Write($"{subject.SubjectID,8}");
                    Console.Write($"{subject.Score.Test1,8}");
                    Console.Write($"{subject.Score.Test2,8}");
                    Console.Write($"{subject.Score.Test3,8}");
                    Console.Write($"{subject.Score.Sum,8}");
                    Console.WriteLine($"{subject.Score.Net,8:F2}");
                }
            }
        }
    }
}
