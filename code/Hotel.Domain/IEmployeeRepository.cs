namespace Hotel.Domain {
    public interface IEmployeeRepository {
        Employee GetEmployeeById(int employeeId);

        int Add(Employee employee);

        void Update(Employee employee);
    }
}
