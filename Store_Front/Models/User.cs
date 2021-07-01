using System;
using System.Collections.Generic;

#nullable disable

namespace Store_Front.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Money { get; set; }
    }
}
