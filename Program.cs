using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack();
            var integer = 6;
            var strings = "Hello this is a string";
            var newStack = new Stack();
            //myStack.Push(null);
            myStack.Push(integer);
            myStack.Push(strings);
            myStack.Push(newStack);

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());

            Console.ReadLine();
        }
    }
}
