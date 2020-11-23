using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExamples()
        {
            var customer = new Customer(true, "Konrad", "Haight", "555-555-5555", "konradhaight@gmail.com" );

            var employee = new Employee();
            employee.FirstName = "Luke";
            employee.HireDate = DateTime.Today;

            var hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.FirstName = "Kim";

            List<Person> people = new List<Person>();

            people.Add(customer);
            people.Add(hourlyEmployee);
            people.Add(employee);

        }
    }
}
