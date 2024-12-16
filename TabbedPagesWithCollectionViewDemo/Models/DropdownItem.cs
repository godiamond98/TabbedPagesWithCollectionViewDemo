﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedPagesWithCollectionViewDemo.Models
{
    public class DropdownItem
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public bool IsSelected { get; set; }
    }
}
