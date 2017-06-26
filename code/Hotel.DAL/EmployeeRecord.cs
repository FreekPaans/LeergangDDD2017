using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hotel.Domain;

namespace Hotel.DAL {
    [Table("Employee")]
    public class EmployeeRecord {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        internal Employee ToEmployee() {
            return new Employee(EmployeeId, FirstName, LastName);
        }

        internal static EmployeeRecord FromEmployee(Employee employee) {
            return new EmployeeRecord {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName
            };
        }
    }
}
