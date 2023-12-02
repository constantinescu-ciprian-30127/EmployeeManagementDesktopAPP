using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminUI
{
    public partial class EditEmployee : Form
    {
        EmployeeService employeeService;
        LoginRequest loginRequest;
        Employee employee;
        List<Role> employeeRoles = new List<Role>();
        List<Role> employeeNotRoles = new List<Role>();
        List<LoginRequest> loginRequests = new List<LoginRequest>();
        public EditEmployee(Employee employee, LoginRequest loginRequest)
        {
            this.employee = employee;
            this.loginRequest = loginRequest;
            this.employeeService = new EmployeeService();
            this.loginRequests.Add(loginRequest);
            this.loginRequests.Add(new LoginRequest { Email = employee.Email });
            InitializeComponent();
            PopulateDatagridView();
        }

        public async void PopulateDatagridView()
        {
            employeeRoles = await employeeService.getAssignRoles(loginRequests);
            rolesDataGridView.AutoGenerateColumns = true;
            rolesDataGridView.DataSource = employeeRoles;

            
            employeeNotRoles = await employeeService.getUnassignRoles(loginRequests);
            employeeNotRolesdataGridView.AutoGenerateColumns = true;
            employeeNotRolesdataGridView.DataSource = employeeNotRoles;
        }

        private async void employeeNotRolesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeNotRolesdataGridView.Columns[e.ColumnIndex].Name == "Action")
            {
                List<Object> data = new List<Object>
                {
                    loginRequests,
                    employeeNotRoles[e.RowIndex]
                };
                String response = await employeeService.assignRole(data);
                if (response.Equals("OK"))
                {
                    PopulateDatagridView();
                    MessageBox.Show("Role has been assigned", "Server");
                }
            }
        }

        private async void rolesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rolesDataGridView.Columns[e.ColumnIndex].Name == "Action1")
            {
                List<Object> data = new List<Object>
                {
                    loginRequests,
                    employeeRoles[e.RowIndex]
                };
                String response = await employeeService.unassignRole(data);
                if (response.Equals("OK"))
                {
                    PopulateDatagridView();
                    MessageBox.Show("Role has been unassigned", "Server");
                }
                else
                {
                    MessageBox.Show("Role has been unassigned", "Server");
                }
                
            }
        }
    }
}
