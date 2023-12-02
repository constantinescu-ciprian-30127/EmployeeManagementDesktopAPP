using Newtonsoft.Json;
using System.Collections.Generic;

namespace adminUI
{
    public class Department
    {
        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("managerID")]
        public string ManagerID { get; set; }

        [JsonProperty("employees")]
        public List<Employee> Employees { get; set; }

        [JsonConstructor]
        public Department(string departmentName, string managerID, List<Employee> employees)
        {
            DepartmentName = departmentName;
            ManagerID = managerID;
            Employees = employees;
        }
    }
}
