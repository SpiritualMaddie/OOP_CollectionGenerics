// Madde Lundström NET22
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_CollectionGenerics
{
    class Program
    {
        public static void Main(string [] args)
        {
            ClassStack classStack = new ClassStack();                   // New object of StackClass
            ClassList classList = new ClassList();                      // New object of ListClass

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("-------------------- Part one - Stack ------------------------------");
            Console.WriteLine("--------------------------------------------------------------------");           
            classStack.StackPush();                                     // Calls methods in StackClass
            classStack.StackPop();                                      // 
            classStack.StackPush();                                     // 
            classStack.StackPeek();                                     // 
            classStack.StackCheck();                                    // Calls methods in StackClass

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("-------------------- Part two - List -------------------------------");
            Console.WriteLine("--------------------------------------------------------------------");
            classList.List();                                           // Calls method in ListClass
        }
    }
}
