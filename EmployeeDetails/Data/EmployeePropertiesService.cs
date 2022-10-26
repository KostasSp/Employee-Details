namespace EmployeeDetails.Data
{
    public class EmployeePropertiesService
    {
        public Task<EmployeeProperties[]> GetEmployeesAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new EmployeeProperties
            {
                Name = "",
                Position = "",
                Skills = "",
            }).ToArray());
        }
    }
}
