// Madde Lundström NET22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CollectionGenerics
{
    class ClassList
    {
        readonly Employee Emp1 = new Employee(1001, "Stefan", "male", 22000);           // New objects created from Employee class
        readonly Employee Emp2 = new Employee(1002, "Zavala", "non-binary", 29000);     //
        readonly Employee Emp3 = new Employee(1003, "Ikora", "female", 30000);          //
        readonly Employee Emp4 = new Employee(1004, "Lily", "female", 25000);           //  
        readonly Employee Emp5 = new Employee(1005, "Ted", "male", 23000);              //

        public void List()                                                              // Method of Contains, Find, FindAll methods for the assignment
        {
            List<Employee> EmpList = new List<Employee>()                               // New list of Employee objects
                {
                    Emp1, Emp2, Emp3, Emp4, Emp5
                };

            // Checks if an object exists in the list and prints it
            string Emp2Check = EmpList.Contains(Emp2) ? "Employee2 object exists in the list" : "Employee2 object does not exist in the list";
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("LIST - CHECKING");
            Console.WriteLine(Emp2Check + "\n--------------------------------------------------------------------");

            // Finds the first male in the list and prints that employee info
            Employee firstMaleList = EmpList.Find(item => item.Gender == "male");
            Console.WriteLine($"First male of the list:\nID: {firstMaleList.ID} - Name: {firstMaleList.Name} - Gender: {firstMaleList.Gender} - Salary: {firstMaleList.Salary} kr");

            // Finds All males in the list and prints them
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Every male of the list:");
            foreach (Employee males in EmpList.FindAll(item => item.Gender == "male"))
            {
                Console.WriteLine($"ID: {males.ID} - Name: {males.Name} - Gender: {males.Gender} - Salary: {males.Salary} kr");
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Press Enter to exit.");
            Console.ReadKey();
        }
    }
}
