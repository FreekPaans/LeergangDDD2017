using System;
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
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        internal Employee ToEmployee() {
            return new Employee(EmployeeId, FirstName, LastName, BirthDate);
        }

        internal void UpdateFromEmployee(Employee employee) {
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            BirthDate = employee.BirthDate;
        }
    }
}
