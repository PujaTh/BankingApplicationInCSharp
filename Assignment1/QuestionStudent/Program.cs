using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondQuestionStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rollNO:");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter class of sttudent");
            string classStudent = Console.ReadLine();
            Console.WriteLine("Enter semester");
            string sem = Console.ReadLine();
            Console.WriteLine("Enter branch");
            string branch = Console.ReadLine();
            Console.WriteLine("Enter the marks in all 5 subjects");
            int[] marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter marks for subject {0}",i+1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Student s1=new Student(rollNo,name,classStudent,sem,branch,marks);
            s1.DisplayDetails();
            s1.DisplayResult();
            Console.ReadLine();


        }
    }

    class Student
    {
        int rollNo;
        string name;
        string classStudent;
        string sem;
        string branch;
        int [] marks=new int[5];

          public Student(int _rollNO, string _name, string _classStu,string _sem, string _branch,int[]_marks)
          {
              this.rollNo = _rollNO;
              this.name = _name;
              this.classStudent = _classStu;
              this.sem = _sem;
              this.branch = _branch;
              this.marks = _marks;
          }

          public void DisplayResult()
          {
              Console.WriteLine("*****Final Result of student is******");
              double average = 0;

              for (int i = 0; i < 5; i++)
              {
                  average += marks[i];

                  if (marks[i] < 35)
                  {
                      Console.WriteLine("**Failed**");
                      return;
                  }

              }

              average = average / 5;
              Console.WriteLine("Average marks of five subjects is :",average);

              if (average < 50)
              {
                  Console.WriteLine("**Failed**");
              }
              else
              {
                  Console.WriteLine("Passed");
              }
          }

          public void DisplayDetails()
          {
              Console.WriteLine("\n*****Details entered by you :*****");
              Console.WriteLine("RollNo : {0}",rollNo);
              Console.WriteLine("Name : {0}",name);
              Console.WriteLine("Class : {0}",classStudent);
              Console.WriteLine("SEM : {0}", sem);
              Console.WriteLine("Branch : {0}",branch);
              for (int i = 0; i < 5; i++)
              {
                  Console.WriteLine(marks[i]);
              }

          }

    }
}
