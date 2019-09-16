using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.Departments
{
    class QualityAssurance : Department
    {
        public QualityAssurance()
        {
            this.DepartmentName = "Quality Assurance";
        }

        internal override void CreateEmployees()
        {
        }
    }
}
