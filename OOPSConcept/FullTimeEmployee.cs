using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class FullTimeEmployee:Employee, IEmployeeBenifits
    {
        public int monthlysalary { get; set; }

        public FullTimeEmployee(int id, string name, string dept, int monthlysal, IFinanceTeam team) : base (id, name, dept, monthlysal, team)
        {
            this.monthlysalary = monthlysal;

        }

        public void GetBenifit()
        {
            //logic
        }
        //Method overloading/compile time polymorphism. [Name matches, but either number or type of parameters need to be
        //[Signature = Name+ReturnType+type and number of arguments]
        public void GetBenifit(string benifitName)
        {
            return;
        }
        //Runtime polymorphism or method overriding
        public override void GetSalary()
        {
            Console.WriteLine("Get Salary in full time employee");
            Console.WriteLine(this.ID+","+this.Name+","+this.salary);
        }
    }
}
