using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.Departments
{

    /// <summary>
    /// This is our abstract department class. From this "factory" we will create different "concrete" departments.
    /// </summary>
    public abstract class Department
    {
        private string _departmentName;

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        private List<Employee> _employees;
        public List<Employee> Employees { get { return _employees; } }
        public Department()
        {
            // instantiate the private _employees variable so it's available for use
            this._employees = new List<Employee>();

            this.CreateEmployees();
        }

        internal abstract void CreateEmployees();
    }
}
