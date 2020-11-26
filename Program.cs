using System;
using System.Collections.Generic;

namespace Practice20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a first number ");
            //int userinput = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter a second number ");


            //int userinputSecond = int.Parse(Console.ReadLine());
            //int c = sum(userinput,userinputSecond);
            //Console.WriteLine("The result is "+ c);

            //int s = Substract(userinput, userinputSecond);
            //int d = sum(userinput, userinputSecond, userinput);
            //Console.WriteLine("The result of subtraction is " + s);

            string[] students = new string[3];
            int[] Age = new int[10];//'10' sets maximum on values, we start from index 0. so the limit is 9 b/c 0 counts
            students[0] = "Albert";
            students[1] = "Blake";
            students[2] = "Danny";

            for (int i = 0; i <students.Length; i++) //   .length is the number of varaibles in legth 

            {
                Console.WriteLine(students[i]);
            }

            // Console.WriteLine(students);
           Console.WriteLine();
           Console.WriteLine(  "------Names in reverse order-------");
            for (int i = students.Length - 1 ; i>=  0; i--)
            {
                Console.WriteLine(students[i]);
            }
           Console.WriteLine("-----While Loop------");
            int y = 0;
            while (y < students.Length)
            {
                Console.WriteLine(students[y]);
                y++;

            }
            Console.WriteLine("----------------Do while loop------");
           int j = 0;
            do
            {
                Console.WriteLine(students[j]);
                j++;
            } while (j < students.Length);
            
            Console.WriteLine("-------ForEach Loop-----------");

            foreach (string item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------");
            List<String> StudentList = new List<string>();
            StudentList.Add("Alberto");
            StudentList.Add("BlakeS");
            StudentList.Add("DannyJ");

            for (int i = 0; i < StudentList.Count; i++)
            {
                Console.WriteLine(StudentList[i]);
            }
            Console.WriteLine("---------------while loop (in a list)--------------");
            int g = 0;
            while (g < StudentList.Count)
            {
                Console.WriteLine(StudentList[g]);
                g++;
            }

            Console.WriteLine("-------------do while (in a list)-----------------");

            int d = 0;
            do
            {
                Console.WriteLine(StudentList[d]);
                d++;
            } while (d < StudentList.Count);


            Console.WriteLine("----------Classes----------------");
            //We use a class to make an object 
           //An object is an instance of a class
           //a class is a blueprint ,template 
           //st1 is an object 
            Student st1 = new Student();
            st1.Age = 30;
            st1.FirstName = "Albert";
            st1.LastName = "Ngoudjou";
            
            Student st2 = new Student("Novoa", "Danny", 18, "Nicaragua ");
            

            Console.WriteLine($"The student name is  {st1.FirstName} and he is {st1.Age} years old and he is from {st1.GetHomTown()} ");
            Console.WriteLine("The student name is "+ st2.FirstName  + " and he is"+ st2.Age +" years old and he is from " + st2.GetHomTown() );
            Console.ReadKey();
        }


        static int sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static double sum (double a, double b)
        {
            double result = a + b;
            return result;

        }

        static int sum(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }

        static int Substract(int num1, int num2)
        {
            int result = num1 - num2;
            return result; 
        }
        
    }

    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set;}
        public int Age { get; set; }
        string HomeTown { get; set; }

       public Student ()
        {
            Age = 30;
            LastName = "NA";
            FirstName = "NA";
        }
        public Student(string lname, string fname, int sage, string home)
        {
            LastName = lname;
            FirstName = fname;
            Age = sage;
            HomeTown = home;
        }

        public string GetHomTown()
        {
            return HomeTown;
        }

    }
}
