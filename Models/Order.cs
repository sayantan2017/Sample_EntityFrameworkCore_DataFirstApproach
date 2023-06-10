using System;
using System.Collections.Generic;

#nullable disable

namespace Sample_EntityFrameworkCore_DataFirstApproach.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int? PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
