using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    class Program
    {
       private List<Employee> list;
        static void Main(string[] args)
        {
            

            int check = 0;
            while ( check == 0)
            {
                Console.WriteLine("seclect number ");
                Console.WriteLine("1. add employee");
                Console.WriteLine("2. delete employee");
                Console.WriteLine("3. update employee");
                Console.WriteLine("0. get out");
                string number= Console.ReadLine();
                switch (number)
                {
                    case "1":
                        
                }
            }
            Console.ReadKey();
        }
        private void add(Employee employ)
        {
            this.list.Add(employ);
        }
        private void delete(int _id)
        {
            this.list.Remove(_id);
        }
        private  Employee iptEmployee()
        {
            Console.WriteLine("input information employee");
            Console.WriteLine("input id employee");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("input name employee");
            string name = Console.ReadLine();
            Console.WriteLine("input gender employee");
            string gender = Console.ReadLine();
            Console.WriteLine("input dateOfBrith employee");
            DateTime dateOfBrith = Convert.ToDateTime( Console.ReadLine());
            Console.WriteLine("input basicSalary employee");
            string basicSalary = Console.ReadLine();
            Employee employee = new Employee(id, name, gender, dateOfBrith, basicSalary);
            return employee;
        }
    }
}
