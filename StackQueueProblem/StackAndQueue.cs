using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueProblem
{
    public class StackAndQueue
    {
        public Node top;
        public void StackQueue()
        {
            this.top= null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if(this.top==null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                node.next=this.top;
            }
            this.top=node;
            Console.WriteLine("pushed data in stack " + data);
        }
        public void Display()
        {
            Node temp = this.top;
            while(temp!=null)
            {
                Console.WriteLine(temp.data+" ");
                temp=temp.next;
            }
        }
    }
}
