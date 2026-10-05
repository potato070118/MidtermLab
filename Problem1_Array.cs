using System;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[10];
        int studentCount = 0;
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("       STUDENT RECORD MANAGEMENT");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Student Number: ");
                students[studentCount].StudentNumber = Console.ReadLine();
                Console.Write("Name: ");
                students[studentCount].Name = Console.ReadLine();
                Console.Write("Program: ");
                students[studentCount].Program = Console.ReadLine();
                Console.Write("Year Level: ");
                students[studentCount].YearLevel = int.Parse(Console.ReadLine());
                studentCount++;
                Console.WriteLine("Student Added Successfully!");
            }
            else if (choice == 2)
            {
                for (int i = 0; i < studentCount; i++)
                    Console.WriteLine(students[i].StudentNumber + " | " + students[i].Name + " | "
                        + students[i].Program + " | " + students[i].YearLevel);
            }
            else if (choice == 3)
            {
                Console.Write("Student Number: ");
                string num = Console.ReadLine();
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == num)
                        Console.WriteLine(students[i].Name + " | " + students[i].Program + " | " + students[i].YearLevel);
                }
            }
            else if (choice == 4)
            {
                Console.Write("Student Number: ");
                string num = Console.ReadLine();
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == num)
                    {
                        Console.Write("Name: ");
                        students[i].Name = Console.ReadLine();
                        Console.Write("Program: ");
                        students[i].Program = Console.ReadLine();
                        Console.Write("Year Level: ");
                        students[i].YearLevel = int.Parse(Console.ReadLine());
                        Console.WriteLine("Updated!");
                    }
                }
            }
            else if (choice == 5)
            {
                Console.Write("Student Number: ");
                string num = Console.ReadLine();
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == num)
                    {
                        for (int j = i; j < studentCount - 1; j++)
                            students[j] = students[j + 1];
                        studentCount--;
                        Console.WriteLine("Deleted!");
                        break;
                    }
                }
            }
        }
        Console.WriteLine("Program Exited.");
    }
}