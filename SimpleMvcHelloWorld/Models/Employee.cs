﻿using System.ComponentModel.DataAnnotations;

namespace SimpleMvcHelloWorld.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId
        {
            get; set;
        }
        public string? FirstName
        {
            get; set;
        }

        public string? LastName
        {
            get; set;
        }
        public int Salary
        {
            get; set;
        }

    }
}
