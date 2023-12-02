using Newtonsoft.Json;
using System.Collections.Generic;

namespace adminUI
{
    public class Employee
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("roles")]
        public List<Role> Roles { get; set; }

        [JsonConstructor]
        public Employee(string firstName, string lastName, string email, List<Role> roles)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Roles = roles;
        }
    }
}
