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
        Node head = null;
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
        public void Peek()
        {
            if(this.top==null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("peek of the stack "+this.top.data);
            Display();
        }
        public void Pop()
        {
            if(this.top==null)
            {
                Console.WriteLine("stack is empty");
                return ;
            }
            Console.WriteLine("pop value is "+this.top.data);
            top=top.next;
        }
        public void IsEmpty()
        {

            while(this.top== null)
            {
                Peek();
                Pop();
            }
        }
        public void Queue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("insert into queue" + node.data);
            }
            Display();
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data+" ");
                temp=temp.next;
            }
        }
    }
}
