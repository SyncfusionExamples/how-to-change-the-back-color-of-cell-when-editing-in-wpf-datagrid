using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Employees = this.GetEmployees();
        }
        private ObservableCollection<EmployeeInfo> _employees;

        public ObservableCollection<EmployeeInfo> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        private ObservableCollection<EmployeeInfo> GetEmployees()
        {
            ObservableCollection<EmployeeInfo> employeeDetails = new ObservableCollection<EmployeeInfo>();
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Ferando", LastName = "Joseph", Title = "Management", Salary = 0, ReportsTo = -1, ID = 2 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "John", LastName = "Adams", Title = "Accounts", Salary = 10000, ReportsTo = -1, ID = 3 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Thomas", LastName = "Jefferson", Title = "Sales", Salary = 300000, ReportsTo = -1, ID = 4 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Andrew", LastName = "Madison", Title = "Marketing", Salary = 0, ReportsTo = -1, ID = 5 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Ulysses", LastName = "Pierce", Title = "HumanResource", Salary = 20000, ReportsTo = -1, ID = 6 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Jimmy", LastName = "Harrison", Title = "Purchasing", Salary = 40000, ReportsTo = -1, ID = 7 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Ronald", LastName = "Fillmore", Title = "Production", Salary = 25000, ReportsTo = -1, ID = 8 });

            return employeeDetails;
        }
    }
}
