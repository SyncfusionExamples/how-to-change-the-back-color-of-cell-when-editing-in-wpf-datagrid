using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class EmployeeInfo
    {
        int _id;
        string _firstName;
        string _lastName;
        private string _title;
        decimal _salary;
        int _reportsTo;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int ReportsTo
        {
            get { return _reportsTo; }
            set { _reportsTo = value; }
        }

        [Display(AutoGenerateField = false)]

        public string Error => string.Empty;

        public string this[string columnName]
        {
            get
            {
                string errorMessage = string.Empty;
                if (!columnName.Equals("Salary"))
                    return string.Empty;
                if (this.Salary < 30000)
                    errorMessage += "The 'Salary'should be less than 30000";
                if (this.Salary == 0)
                    errorMessage += "\nThe 'Salary'should have some values";

                return errorMessage;
            }
        }

        [Display(AutoGenerateField = false)]

        public bool HasErrors
        {
            get
            {
                return false;
            }
        }

        private List<string> errors = new List<string>();
        public IEnumerable GetErrors(string propertyName)
        {
            return errors;
        }
    }
}
