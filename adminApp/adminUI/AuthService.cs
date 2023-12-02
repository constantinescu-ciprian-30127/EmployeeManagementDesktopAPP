using System;
using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace adminUI
{
    
    public class AuthService
    {
        private const string BackendUrl = "http://localhost:8080/login"; // Înlocuiți cu URL-ul real al serviciului de autentificare

        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                // Construiți obiectul JSON pentru a trimite către serviciul de autentificare
                var content = new StringContent($"{{\"email\": \"{username}\", \"password\": \"{password}\"}}", System.Text.Encoding.UTF8, "application/json");
               
                // Realizați cererea POST către serviciul de autentificare
                HttpResponseMessage response = await client.PostAsync(BackendUrl, content);
                

                // Verificați dacă răspunsul indică o autentificare reușită
                return response.IsSuccessStatusCode;
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }

}
