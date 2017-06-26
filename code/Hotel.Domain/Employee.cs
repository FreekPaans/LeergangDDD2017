namespace Hotel.Domain {
    public class Employee {
        public Employee(int employeeId, string firstName, string lastName)
            : this(firstName, lastName) {
            EmployeeId = employeeId;
        }

        public Employee(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
