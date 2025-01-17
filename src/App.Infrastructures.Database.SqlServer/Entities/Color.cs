﻿using System;
using System.Collections.Generic;

namespace App.Infrastructures.Database.SqlServer.Entities
{
    public partial class Color
    {
        public Color()
        {
            ProductColors = new HashSet<ProductColor>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ProductColor> ProductColors { get; set; }
    }
}
