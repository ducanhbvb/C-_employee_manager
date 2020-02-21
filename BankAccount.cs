namespace EmployeeManager
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Note { get; set; }
    }
}
