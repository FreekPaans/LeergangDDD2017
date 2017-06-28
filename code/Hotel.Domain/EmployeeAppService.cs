using System;

namespace Hotel.Domain {
    public class EmployeeAppService {
        private IEmployeeRepository _employeeRepository;

        public EmployeeAppService(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }

        public Employee LoadEmployee(int employeeId) {
            return _employeeRepository.GetEmployeeById(employeeId);
        }

        public int CreateEmployee(string firstName, string lastName, DateTime birthDate) {
            var employee = new Employee(firstName, lastName, birthDate);
            return _employeeRepository.Add(employee);
        }

        public void UpdateEmployee(Employee employee) {
            _employeeRepository.Update(employee);
        }
    }
}
