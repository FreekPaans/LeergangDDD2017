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
            var employeeRecord = EmployeeRecord.FromEmployee(employee);

            using (var context = new HotelDbContext()) {
                context.EmployeeRecords.Add(employeeRecord);

                context.SaveChanges();
            }

            return employeeRecord.EmployeeId;
        }
    }
}
