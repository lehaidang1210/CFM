﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CFM.DataAccess
{
    public partial class Table
    {
        public Table()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Note { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
