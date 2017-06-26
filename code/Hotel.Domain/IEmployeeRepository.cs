namespace Hotel.Domain {
    public interface IEmployeeRepository {
        Employee GetEmployeeById(int employeeId);
    }
}
