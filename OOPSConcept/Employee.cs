using System;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    abstract class Employee
    {
        /*public Employee(int id, string name, string dept, int sal)
        {
            ID = id;
            Name = name;
            Department = dept;
            salary = sal;
        }*/

        //public ITTeam ITTeam { get; set; }
        public IFinanceTeam FinanceTeam { get; set; }
        //public FinanceTeam obj;

        public Employee(int id, string name, string dept, int sal, IFinanceTeam team)
        {
            this.ID = id;
            this.Name = name;
            this.Department = dept;
            this.salary = sal;
            //ITTeam = new ITTeam();
            FinanceTeam = team;            
         }

        private int _ID;
        public int ID 
        {
            get
            {
                return this._ID;
            }
            set 
            {
                if (!this.Validate(value))
                {
                    throw new Exception("Invalid value");
                }    
                this._ID = value;
            }            
        }

        private bool Validate(int id)
        {
            if (id < 1)
            {
                return false;
            }
            return true;
        }
        public string Name { get; set; }
        public string Department { get; set; }

        public int salary { get; set; }
   

        public void DoWork()
        {
            //ITTeam.SolveProblem();
        }

        public virtual void GetSalary()
        {
            Console.WriteLine(this.ID+" "+this.Name+" "+this.Department);
            Console.WriteLine("Salary credited "+this.salary);
            FinanceTeam.TakeRequestFromEmployee();
        }
        
    }
}
