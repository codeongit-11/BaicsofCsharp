using System;
using BLL;
using StudentInformation;

namespace OOPSConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee(11, "Bala","IT");
            PartTimeEmployee emp1 = new PartTimeEmployee(13, "Kishore", "IT", 5600,(IFinanceTeam)DependencyResolver.GetInstance("IFinanceTeam"));
            emp1.GetSalary();            
            FullTimeEmployee emp2 = new FullTimeEmployee(18, "Roopesh", "IT", 5700,(IFinanceTeam)DependencyResolver.GetInstance("IFinanceTeam"));
            emp2.GetSalary();
            Console.WriteLine("Hello, World!");
            emp2.GetBenifit("Insurance");
        }
        
    }
}

