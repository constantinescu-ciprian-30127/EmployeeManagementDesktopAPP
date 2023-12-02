using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace adminUI
{
    public partial class Form1 : Form
    {
        EmployeeService employeeService;
        List<Employee> employees;
        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            var loginRequest = new LoginRequest
            {
                Email = email,
                Password = password
            };

            string apiUrl = "http://localhost:8080/director/login";
            var result = await employeeService.Login(apiUrl, loginRequest);
            if(result.Equals(HttpStatusCode.NoContent))
            {
                MessageBox.Show("Failed to login.", "Server");
            }
            else
            {
                if (result.Equals(HttpStatusCode.NotFound))
                {
                    MessageBox.Show("User not found.", "Server");
                }
                else
                {
                    if (result.Equals(HttpStatusCode.Unauthorized))
                    {
                        MessageBox.Show("You don't have access to application.", "Server");
                    }
                    else
                    {
                        if (result.Equals(HttpStatusCode.NotAcceptable))
                        {
                            MessageBox.Show("Incorrect password.", "Server");
                        }
                        else
                        {
                            if (result.Equals(HttpStatusCode.Found))
                            {
                                AdminDashboard adminDashboard = new AdminDashboard(txtUsername.Text, txtPassword.Text);
                                adminDashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show(result.ToString(), "Server");
                            }
                        }
                    }
                }
                
            }
        }
    }
}
