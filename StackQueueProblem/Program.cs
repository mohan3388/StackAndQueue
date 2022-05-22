using System;
using StackQueueProblem;
class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to program");
        Console.WriteLine("1.press 1 to display push data\n2.press 2 to display pop and peek item");
        bool check = true;
        while (check)
        {
            Console.WriteLine("enter above option");
            int option = Convert.ToInt32(Console.ReadLine());
            StackAndQueue stack = new StackAndQueue();
            switch (option)
            {
                case 1:
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
                    break;
                    case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                   
                    stack.Pop();
            stack.Peek();
                    break;

        }
            }
    }
}