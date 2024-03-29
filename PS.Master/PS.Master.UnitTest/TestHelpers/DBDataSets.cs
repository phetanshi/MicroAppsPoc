﻿using Microsoft.EntityFrameworkCore;

namespace PS.Master.UnitTest.TestHelpers
{
    public static class DBDataSets
    {
        public static List<Employee> GetEmployeeTableTestData()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { EmployeeId = 1234, UserId = "CORP\\e999999", FirstName = "TestOne", LastName = "One", CreatedBy = DateTime.Now.ToString() });
            employees.Add(new Employee { EmployeeId = 4321, UserId = "CORP\\e777777", FirstName = "TestTwo", LastName = "Two", CreatedBy = DateTime.Now.ToString() });
            employees.Add(new Employee { EmployeeId = 7657, UserId = "CORP\\e666666", FirstName = "TestThree", LastName = "Three", CreatedBy = DateTime.Now.ToString() });

            return employees;
        }
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(GetEmployeeTableTestData());
        }
    }
}
