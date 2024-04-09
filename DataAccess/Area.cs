using System;
using System.Collections.Generic;

#nullable disable

namespace CFM.DataAccess
{
    public partial class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? SoftDelete { get; set; }
    }
}
