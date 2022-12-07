using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_20170140031
{
    class Program
    {
        static void Main(string[] args)
        {
            Exe4_20170140031.Stack sa = new Exe4_20170140031.Stack();
            sa.Run(); 

        }
    }

    class Stack
    {
        int[] stack_array = new int[5];
        int top;

        public Stack()
        {
            top = -1;
        }

        public bool full()
        {
            if (top == 4)
                return (true);
            else
                return (false);
        }

        public bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);
        }

        public void push(int item)
        {
            top = top + 1;
            stack_array[top] = item;
            Console.WriteLine();
            Console.WriteLine(item + " pushed. ");
        }

        public void pop()
        {
            Console.WriteLine("\nThe popped item is: " + stack_array[top]);
            top = top - 1;
        }

        public void display()
        {
            int i;

            if (empty())
                Console.WriteLine("\nStack empty");
            else
            {
                Console.WriteLine("\nThe contents of the stack are:\n ");
                for (i = top; i >= 0; i--)
                    Console.WriteLine(stack_array[i]);

                Console.WriteLine();
            }
        }

        public void Run()
        {
            Stack obj = new Stack();
            char choice;

            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");

                Console.Write("\nEnter your choice: ");

                choice = Convert.ToChar(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        int item;
                        if (obj.full())
                        {
                            Console.WriteLine("\nStack full");
                            break;
                        }
                        Console.Write("\nEnter a number: ");
                        item = Convert.ToInt32(Console.ReadLine());
                        obj.push(item);
                        break;
                    case '2':
                        if (obj.empty())
                        {
                            Console.WriteLine("\nStack empty");
                            break;
                        }
                        obj.pop();
                        break;
                    case '3':
                        obj.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. ");
                        break;
                }
            }
        }
    }
}

