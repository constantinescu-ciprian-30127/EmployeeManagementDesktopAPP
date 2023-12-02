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
    public partial class ManageEmployee : Form
    {
        List<Employee> employees = new List<Employee>();
        public ManageEmployee(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponent();
            PopulateDatagridView();
        }

        public void PopulateDatagridView()
        {
            employeesDataGridView.AutoGenerateColumns = true;
            employeesDataGridView.DataSource = employees;
        }
    }
}
