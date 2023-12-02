using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;

namespace adminUI
{
    internal class EmployeeService
    {
        HttpClientHandler clientHandler = null;
        static HttpClient client = null;

        public EmployeeService()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            client = new HttpClient(clientHandler);
        }

        public void createConnection()
        {

            client.BaseAddress = new Uri("http://localhost:8080/director");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<List<Employee>> getAllEmployees(LoginRequest loginRequest)
        {
            List<Employee> employees = new List<Employee>();
            
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response1 = await client.PostAsync("http://localhost:8080/director/showEmployees", content);

                if (response1.IsSuccessStatusCode)
                {   
                    string resultString = response1.Content.ReadAsStringAsync().Result;
                    employees = JsonConvert.DeserializeObject<List<Employee>>(resultString);
                    return employees;
                }
                else
                {
                    return null;
                }
            }
        }


        public async Task<List<Role>> getUnassignRoles(List<LoginRequest> loginRequest)
        {
            List<Role> roles = new List<Role>();

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response1 = await client.PostAsync("http://localhost:8080/director/getEmployeeNotRoles", content);

                if (response1.IsSuccessStatusCode)
                {
                    string resultString = response1.Content.ReadAsStringAsync().Result;
                    roles = JsonConvert.DeserializeObject<List<Role>>(resultString);
                    return roles;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Role>> getAssignRoles(List<LoginRequest> loginRequest)
        {
            List<Role> roles = new List<Role>();

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response1 = await client.PostAsync("http://localhost:8080/director/getEmployeeRoles", content);

                if (response1.IsSuccessStatusCode)
                {
                    string resultString = response1.Content.ReadAsStringAsync().Result;
                    roles = JsonConvert.DeserializeObject<List<Role>>(resultString);
                    return roles;
                }
                else
                {
                    return null;
                }
            }
        }


        public async Task<String> assignRole(List<Object> data)
        {

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response1 = await client.PostAsync("http://localhost:8080/director/assignRoleToEmployee", content);

                if (response1.IsSuccessStatusCode)
                {
                    string resultString = response1.Content.ReadAsStringAsync().Result;
                    return resultString;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<String> unassignRole(List<Object> data)
        {

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response1 = await client.PostAsync("http://localhost:8080/director/unassignRoleFromEmployee", content);

                if (response1.IsSuccessStatusCode)
                {
                    string resultString = response1.Content.ReadAsStringAsync().Result;
                    return resultString;
                }
                else
                {
                    return null;
                }
            }
        }



        public async Task<HttpStatusCode> Login(string apiUrl, LoginRequest loginRequest)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                try
                {
                    var response = await client.PostAsync(apiUrl, content);
                    if (!response.StatusCode.Equals(HttpStatusCode.NoContent))
                    {
                        return response.StatusCode;
                    }
                    return HttpStatusCode.NoContent;
                }
                catch (HttpRequestException ex)
                {
                    return HttpStatusCode.NoContent;
                }
                

                
            }
        }


    }
}
