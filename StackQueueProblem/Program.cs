using System;
using StackQueueProblem;
class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to program");
        Console.WriteLine("1.press 1 to display push data\n2.press 2 to display pop and peek item\n3.press 3 to display Queue item\n4.press 4 to display dequeue items");
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
                case 3:
                    stack.Queue(70);
                    stack.Queue(30);
                    stack.Queue(56);
                    break;
                case 4:
                    stack.Queue(70);
                    stack.Queue(30);
                    stack.Dequeue();
                    break;
                default:
                    check = false;
                    break;

            }
            }
    }
}