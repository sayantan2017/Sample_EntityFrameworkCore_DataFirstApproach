using System;
using System.Collections.Generic;

#nullable disable

namespace Sample_EntityFrameworkCore_DataFirstApproach.Models
{
    public partial class Gadget
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public decimal Cost { get; set; }
        public string ImageName { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
