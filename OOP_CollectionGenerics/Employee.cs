// Madde Lundström NET22
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CollectionGenerics
{
    public class Employee
    {
        private int id;
        private string gender;
        public int ID 
        { 
            get { return id; }
            set
            {
                if (value >= 1000)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Our ID numbers start with 1000");
                }
            } 
        }
        public string Name { get; set; }
        public string Gender 
        {
            get { return gender; }
            set 
            {
                if (value == "male" || value == "female" || value == "non-binary") 
                {
                    gender = value;
                }
                else
                {
                    throw new Exception("This program only has three genders");
                }
            } 
        }
        public int Salary { get; set; }
        public Employee(int aID, string aName, string aGender, int aSalary)
        {
            this.ID = aID;
            this.Name = aName;
            this.Gender = aGender;
            this.Salary = aSalary;
        }
    }
}
