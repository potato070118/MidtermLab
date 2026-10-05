using System;
using System.Collections.Generic;

struct Student
{
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
        int choice = 0;

        while (choice !=4)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("        STUDENT LOOKUP USING DICTIONARY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

           if (choice == 1)
{
    Console.Write("Student Number: ");
    string num = Console.ReadLine();

    if (studentDictionary.ContainsKey(num))
    {
        Console.WriteLine("Student Number already exists");
    }
    else
    {
        Student s = new Student();
        Console.Write("Name: ");
        s.Name = Console.ReadLine();
        Console.Write("Program: ");
        s.Program = Console.ReadLine();
        Console.Write("Year Level: ");
        s.YearLevel = int.Parse(Console.ReadLine());

        studentDictionary.Add(num, s);
        Console.WriteLine("Student Added Successfully");
    }
}
            else if (choice == 2)
            {
                Console.Write("Enter Student Number to Search: ");
                string num = Console.ReadLine();

                if (studentDictionary.ContainsKey(num))
                {
                    Student s = studentDictionary[num];
                    Console.WriteLine("Student Found");
                    Console.WriteLine("Student Number: " + num);
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Program: " + s.Program);
                    Console.WriteLine("Year Level: " + s.YearLevel);
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }
            }
                else if (choice == 3)
            {
                foreach (string num in studentDictionary.Keys)
                {
                    Student s = studentDictionary[num];
                    Console.WriteLine(num + " | " + s.Name + " | " + s.Program + " | " + s.YearLevel);
                }
            }
        }
        Console.WriteLine("Program Exited");
     }
 }