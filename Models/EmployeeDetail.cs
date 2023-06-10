using System;
using System.Collections.Generic;

#nullable disable

namespace Sample_EntityFrameworkCore_DataFirstApproach.Models
{
    public partial class EmployeeDetail
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public float Salary { get; set; }
    }
}
