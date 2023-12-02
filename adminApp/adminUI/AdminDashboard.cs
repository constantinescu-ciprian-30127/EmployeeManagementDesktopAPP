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
    public partial class AdminDashboard : Form
    {
        EmployeeService employeeService;
        DepartmentService departmentService;
        List<Employee> employees;
        List<Employee> employeesList = new List<Employee>();
        List<Department> departments;
        List<Department> departmentsList = new List<Department>();
        String email;
        String password;
        public AdminDashboard(String email, String password)
        {   
            employeeService = new EmployeeService();
            departmentService = new DepartmentService();
            this.email = email;
            this.password = password;
            InitializeComponent();
            InitializeEmployeesAndDepartment();
        }

        private async void InitializeEmployeesAndDepartment()
        {
            employeesList = await employeeService.getAllEmployees(new LoginRequest { Email = this.email, Password = this.password });
            employeeService.createConnection();
            employees = new List<Employee>();
            foreach (Employee employee in employeesList)
            {
                employees.Add(employee);
            }

            departmentsList = await departmentService.getAllDepartment(new LoginRequest { Email = this.email, Password = this.password });
            departmentService.createConnection();
            departments = new List<Department>();
            foreach (Department department in departmentsList)
            {
                departments.Add(department);
            }

            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            employeesDataGridView.AutoGenerateColumns = true;
            employeesDataGridView.DataSource = employees;
            departmentsDataGridView.AutoGenerateColumns = true;
            departmentsDataGridView.DataSource = departments;
        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeesDataGridView.Columns[e.ColumnIndex].Name == "Action")
            {
                EditEmployee editEmployee = new EditEmployee(employees[e.RowIndex], new LoginRequest { Email = this.email, Password = this.password });
                editEmployee.Show();
            }
        }

        private void departmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (departmentsDataGridView.Columns[e.ColumnIndex].Name == "Action1")
            {
                ManageEmployee manageEmployee = new ManageEmployee(departments[e.RowIndex].Employees);
                manageEmployee.Show();
            }
        }
    }
}
