using System;

namespace EmployeeManager
{
    public class Employee
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBrith { get; set; }
        public string Age
        {
            get { return string.Format("{0}", DateTime.Now.Year - DateOfBrith.Year);}
        }
        public int CMND { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuedAddress { get; set; }
        public byte[] Avatar { get; set; }
        public Decimal BasicSalary { get; set; }
    }
}
