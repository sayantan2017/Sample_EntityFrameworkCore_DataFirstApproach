using System;
using System.Collections.Generic;

#nullable disable

namespace Sample_EntityFrameworkCore_DataFirstApproach.Models
{
    public partial class Person
    {
        public Person()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
