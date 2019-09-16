using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.Departments
{
    class Development : Department
    {
        public Development()
        {
            this.DepartmentName = "Development";
        }
        internal override void CreateEmployees()
        {
            Employees.Add(new Employee("Paul", "West", this, 1000000, SalaryInterval.Monthly));
        }

    }
}
