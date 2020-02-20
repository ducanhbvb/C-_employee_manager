using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class Employee
    {
        private int id;
        private string name;
        private string gender;
        private DateTime dateOfBrith;
        private BankAccount bankAccount;
        private Decimal basicSalary;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBrith { get; set; }
        public BankAccount[] BankAccount { get; set; }
        public string BasicSalary { get; set; }


        public new void totring()
        {
            Console.WriteLine("id :{0}",this.id);
            Console.WriteLine("id :{0}", this.name);
            Console.WriteLine("id :{0}", this.gender);
            Console.WriteLine("id :{0}", this.dateOfBrith);
            Console.WriteLine("id :{0}", this.basicSalary);
            Console.WriteLine("id :{0}", this.id);
        }

    }
}
