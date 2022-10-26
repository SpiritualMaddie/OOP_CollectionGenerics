// Madde Lundström NET22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CollectionGenerics
{
    class ClassStack
    {
        readonly Employee Emp1 = new Employee(1001, "Stefan", "male", 22000);           // New objects created from Employee class
        readonly Employee Emp2 = new Employee(1002, "Zavala", "non-binary", 29000);     //
        readonly Employee Emp3 = new Employee(1003, "Ikora", "female", 30000);          //
        readonly Employee Emp4 = new Employee(1004, "Lily", "female", 25000);           //
        readonly Employee Emp5 = new Employee(1005, "Ted", "male", 23000);              //
        
        Stack<Employee> EmpStack = new Stack<Employee>();                               // New stack of Employee objects
        
        public void StackPush()                                                         // Method that pushes Employee objects into stack and prints them
        {
            EmpStack.Push(Emp5);
            EmpStack.Push(Emp4);
            EmpStack.Push(Emp3);
            EmpStack.Push(Emp2);
            EmpStack.Push(Emp1);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("STACK - EMPLOYEES ADDED:");
            foreach (Employee itemShow in EmpStack)
            {
                Console.WriteLine($"ID: {itemShow.ID} - Name: {itemShow.Name} - Gender: {itemShow.Gender} - Salary: {itemShow.Salary} kr");
                Console.WriteLine("Number of employees in stack: " + EmpStack.Count());
                Console.WriteLine();
            }
        }
        // Method that pops Employee objects out of the stack one by one and counts amount left in stack and prints the result
        public void StackPop()                                                          
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("STACK - EMPLOYEES REMOVED:");
            dynamic[] EmpPopArray = EmpStack.ToArray();

            foreach (Employee itemPop in EmpPopArray)
            {
                Console.WriteLine("Emplyee removed: ");
                EmpStack.Pop();
                Console.WriteLine($"ID: {itemPop.ID} - Name: {itemPop.Name} - Gender: {itemPop.Gender} - Salary: {itemPop.Salary} kr");
                Console.WriteLine("Number of employees left: " + EmpStack.Count());
                Console.WriteLine();
            }
        }
        // Method that Peeks into the stack to see if object is there and prints it
        public void StackPeek()
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("STACK - PEEKING");
            Employee EmpPeek1 = EmpStack.Peek();
            Employee EmpPeek2 = EmpStack.Peek();
            Console.WriteLine($"ID: {EmpPeek1.ID} - Name: {EmpPeek1.Name} - Gender: {EmpPeek1.Gender} - Salary: {EmpPeek1.Salary} kr");
            Console.WriteLine("Number of employees left: " + EmpStack.Count());
            Console.WriteLine($"ID: {EmpPeek2.ID} - Name: {EmpPeek2.Name} - Gender: {EmpPeek2.Gender} - Salary: {EmpPeek2.Salary} kr");
            Console.WriteLine("Number of employees left: " + EmpStack.Count());
        }
        // Method that checks if an object is in the stack and prints out the result
        public void StackCheck()
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("STACK - CHECKING");
            string Emp3Check = EmpStack.Contains(Emp3) ? "Emp3 is in the stack" : "Employee does not exist";
            Console.WriteLine(Emp3Check);
        }
    }
}
