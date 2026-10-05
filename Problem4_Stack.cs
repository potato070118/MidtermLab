using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

class Program
{
    static void Main()
    {
        Stack<Operation> operationHistory = new Stack<Operation>();
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("           OPERATION HISTORY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. View Operation History");
            Console.WriteLine("2. View Last Operation");
            Console.WriteLine("3. Remove Last Operation");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No recorded operations.");
                }
                else
                {
                    Console.WriteLine("OPERATION HISTORY");
                    Operation[] ops = operationHistory.ToArray();
                    for (int i = ops.Length - 1; i >= 0; i--)
                        Console.WriteLine((ops.Length - i) + ". " + ops[i].Action + " " + ops[i].StudentName);
                }
            }
            else if (choice == 2)
            {
                if (operationHistory.Count == 0)
                    Console.WriteLine("No recorded operations.");
                else
                    Console.WriteLine("Last Operation: " + operationHistory.Peek().Action + " " + operationHistory.Peek().StudentName);
            }
            else if (choice == 3)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No recorded operations.");
                }
                else
                {
                    operationHistory.Pop();
                    Console.WriteLine("Last operation removed successfully!");
                }
            }
        }
        Console.WriteLine("Program exited.");
    }
}