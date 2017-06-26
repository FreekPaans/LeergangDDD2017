using System;

namespace Hotel.Domain {
    public class Employee {
        public Employee(int employeeId, string firstName, string lastName, DateTime birthDate)
            : this(firstName, lastName, birthDate) {
            EmployeeId = employeeId;
        }

        public Employee(string firstName, string lastName, DateTime birthDate) {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }

        public void UpdatePersonalData(string firstName, string lastName, DateTime birthDate) {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
