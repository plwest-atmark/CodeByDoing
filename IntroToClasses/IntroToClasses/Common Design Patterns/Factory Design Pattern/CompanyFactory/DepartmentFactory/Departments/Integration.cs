using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.Departments
{
    class Integration : Department
    {
        public Integration()
        {
            this.DepartmentName = "Integration";
        }

        internal override void CreateEmployees()
        {
        }
    }
}
