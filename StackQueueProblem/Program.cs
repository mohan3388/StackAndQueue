using System;
using StackQueueProblem;
class Program
{
    public static void Main(String[] args)
    {
        StackAndQueue stack = new StackAndQueue();
        stack.Push(70);
        stack.Push(30);
        stack.Push(56);
        stack.Display();
    }
}