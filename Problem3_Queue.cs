using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("           STUDENT REQUEST QUEUE");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                StudentRequest r = new StudentRequest();
                Console.Write("Student Number: ");
                r.StudentNumber = Console.ReadLine();
                Console.Write("Student Name: ");
                r.StudentName = Console.ReadLine();
                Console.Write("Request Type: ");
                r.RequestType = Console.ReadLine();

                requestQueue.Enqueue(r);
                Console.WriteLine("Request added successfully!");
            }
            else if (choice == 2)
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                }
                else
                {
                    int num = 1;
                    foreach (StudentRequest r in requestQueue)
                    {
                        Console.WriteLine(num + ". " + r.StudentName + " - " + r.RequestType);
                        num++;
                    }
                }
            }
            else if (choice == 3)
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                }
                else
                {
                    StudentRequest r = requestQueue.Dequeue();
                    Console.WriteLine("Processing Request: " + r.StudentName + " - " + r.RequestType);
                    Console.WriteLine("Request processed successfully!");
                }
            }
        }
        Console.WriteLine("Program exited.");
    }
}