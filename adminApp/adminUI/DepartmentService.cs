using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace adminUI
{
    internal class DepartmentService
    {
        HttpClientHandler clientHandler = null;
        static HttpClient client = null;

        public DepartmentService()
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

        public async Task<List<Department>> getAllDepartment(LoginRequest loginRequest)
        {
            List<Department> departments = new List<Department>();
            
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response1 = await client.PostAsync("http://localhost:8080/director/showDepartments", content);

                if (response1.IsSuccessStatusCode)
                {   
                    string resultString = response1.Content.ReadAsStringAsync().Result;
                    departments = JsonConvert.DeserializeObject<List<Department>>(resultString);
                    return departments;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
