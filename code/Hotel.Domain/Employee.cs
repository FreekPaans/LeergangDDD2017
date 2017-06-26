namespace Hotel.Domain {
    public class Employee {
        public Employee(int employeeId, string firstName)
            : this(firstName) {
            EmployeeId = employeeId;
        }

        public Employee(string firstName) {
            FirstName = firstName;
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
    }
}
