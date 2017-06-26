using System.Linq;
using Hotel.Domain;

namespace Hotel.DAL {
    public class EmployeeRepository : IEmployeeRepository {
        public Employee GetEmployeeById(int employeeId) {
            using (var context = new HotelDbContext()) {
                return context.EmployeeRecords.Single(_ => _.EmployeeId == employeeId).ToEmployee();
            }
        }

        public int Add(Employee employee) {
            var employeeRecord = new EmployeeRecord();

            using (var context = new HotelDbContext()) {
                employeeRecord.UpdateFromEmployee(employee);

                context.EmployeeRecords.Add(employeeRecord);

                context.SaveChanges();
            }

            return employeeRecord.EmployeeId;
        }

        public void Update(Employee employee) {
            using (var context = new HotelDbContext()) {
                var employeeRecord = context.EmployeeRecords.Single(_ => _.EmployeeId == employee.EmployeeId);

                employeeRecord.UpdateFromEmployee(employee);

                context.SaveChanges();
            }
        }
    }
}
