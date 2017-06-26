using System;
using Hotel.DAL;
using Hotel.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel.Tests {
    [TestClass]
    public class EmployeeRepositoryTests {
        [TestMethod]
        public void can_save_employee() {
            var employeeToSave = new Employee("Foo", "Bar", new DateTime(1990, 03, 01));

            int employeeId = SaveEmployee(employeeToSave);

            Assert.IsTrue(employeeId > 0, "employeeId should be greater than 0 after save");
        }

        [TestMethod]
        public void can_load_employee() {
            var employeeToSave = new Employee("Foo2", "Bar2", new DateTime(1991, 06, 02));

            var employee = SaveAndLoadEmployee(employeeToSave);

            Assert.AreEqual("Foo2", employee.FirstName);
            Assert.AreEqual("Bar2", employee.LastName);
            Assert.AreEqual(new DateTime(1991, 06, 02), employee.BirthDate);
        }

        private static Employee SaveAndLoadEmployee(Employee employeeToSave) {
            int employeeId = SaveEmployee(employeeToSave);

            var repository = new EmployeeRepository();
            var employee = repository.GetEmployeeById(employeeId);

            return employee;
        }

        private static int SaveEmployee(Employee employeeToSave) {
            var repository = new EmployeeRepository();

            var employeeId = repository.Add(employeeToSave);
            return employeeId;
        }
    }
}