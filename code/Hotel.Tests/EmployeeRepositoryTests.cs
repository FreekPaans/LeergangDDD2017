using System;
using Hotel.DAL;
using Hotel.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel.Tests {
    [TestClass]
    public class EmployeeRepositoryTests {
        [TestMethod]
        public void can_add_employee() {
            var employeeToSave = new Employee("Foo", "Bar", new DateTime(1990, 03, 01));

            int employeeId = AddEmployee(employeeToSave);

            Assert.IsTrue(employeeId > 0, "employeeId should be greater than 0 after save");
        }

        [TestMethod]
        public void can_load_employee() {
            var employeeToSave = new Employee("Foo2", "Bar2", new DateTime(1991, 06, 02));

            var employee = AddAndLoadEmployee(employeeToSave);

            Assert.AreEqual("Foo2", employee.FirstName);
            Assert.AreEqual("Bar2", employee.LastName);
            Assert.AreEqual(new DateTime(1991, 06, 02), employee.BirthDate);
        }

        [TestMethod]
        public void can_update_existing_employee() {
            var employeeToSave = new Employee("Foo3", "Bar3", new DateTime(1992, 09, 03));
            var employeeToUpdate = AddAndLoadEmployee(employeeToSave);

            employeeToUpdate.UpdatePersonalData("Foo3-1", "Bar3-1", new DateTime(1993, 12, 04));
            var updatedEmployee = UpdateAndLoadEmployee(employeeToUpdate);

            Assert.AreEqual("Foo3-1", updatedEmployee.FirstName);
            Assert.AreEqual("Bar3-1", updatedEmployee.LastName);
            Assert.AreEqual(new DateTime(1993, 12, 04), updatedEmployee.BirthDate);
        }

        private static Employee AddAndLoadEmployee(Employee employeeToSave) {
            int employeeId = AddEmployee(employeeToSave);

            var repository = new EmployeeRepository();
            var employee = repository.GetEmployeeById(employeeId);

            return employee;
        }

        private static Employee UpdateAndLoadEmployee(Employee employeeToSave) {
            var repository = new EmployeeRepository();

            repository.Update(employeeToSave);
            var employee = repository.GetEmployeeById(employeeToSave.EmployeeId);

            return employee;
        }

        private static int AddEmployee(Employee employeeToSave) {
            var repository = new EmployeeRepository();

            var employeeId = repository.Add(employeeToSave);
            return employeeId;
        }
    }
}