using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.Departments;
using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.EmployeeProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory
{
    public interface IPayrollSystem
    {
        void AdjustSalary(Employee employee);
        void PayEmployees(Employee employee);
    }
    public class PayRollSystem : IPayrollSystem
    {
        public void AdjustSalary(Employee employee)
        {
            // Here we would get Development database information on employees that have their salary adjusted for whatever reason, along with how much it's adjusted.
            // For this example, let's assume the data came back saying that "Paul" gets a 20% bonus... the code below just does this, but in the real world,
            // this is a complex calculation that uses information from a database.
            if (employee.FirstName == "Paul") // In this example we will say that the database returned that "Bob" had time off.
            {
                employee.AdjustedSalary = employee.Salary + (employee.Salary / .8); // this removes 20% of their salary.
            }

            // Here we would use a database to access information and determine if any of the employees had unpaid time off of work. Then we would calculate
            // the difference in their pay, update the employee for this "pay period" and then let the rest of the departments handle what they need.
            if (employee.FirstName == "Rob") // In this example we will say that the database returned that "Bob" had time off.
            {
                employee.AdjustedSalary = employee.Salary / .2; // this removes 20% of their salary.
            }
        }

        /// <summary>
        /// This is a virtual method within the "base factory" because "ALL" companies pay their employees.
        /// 
        /// 
        /// We "could" allow the "child" companies to create their own method for "paying" their employees... so we
        /// ALSO set this class to virtual. This means that if a company WANTS to, they can "override" this payroll method.
        /// 
        /// For example: what if they do not call their "payroll" department payroll? They can use the Human Resources class to "pay their" employe
        /// </summary>
        public void PayEmployees(Employee employee)
        {

            // we need to allow for every employee to have an "adjustment" to their pay based on some database information.
                AdjustSalary(employee);
            // get the payroll department from the company (THIS MIGHT BE HUMAN RESOURCES IN SOME COMPANIES, but we have to "fake" out the program and use payroll class)
            // basically, even if a company calls their payroll Human Resources, we need to use the payroll we created to actually pay people.

            // This is where we would use the properties of employee.Salary and employee.SalaryInterval to
            // calculate how much we need to pay, and depending on the date and when they were paid last.. 
            // IF we should pay them or not.
            if (EmployeeShouldBePaidToday(employee))
            {
                var salary = CalculateSalaryToBePaid(employee);
                Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} as paid {salary}. Their normal salary is {employee.Salary}");
            }
        }

        private bool EmployeeShouldBePaidToday(Employee employee)
        {
            // this is where we determine if the employee should be paid
            return true;  // let's just say everyone will be paid
        }

        private double CalculateSalaryToBePaid(Employee employee)
        {
            // this is where the salary will be calculated
            if (employee.AdjustedSalary != 0)
                return employee.AdjustedSalary; // let's say everyone will be paid their max salary. (i.e. PAYDAY!!!)
            else
                return employee.Salary;
        }
    }
}
