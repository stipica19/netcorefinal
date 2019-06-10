﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozo.Controllers.AutoComplete
{
    public class IdLabel
    {
        public string Label { get; set; }
        public int Id { get; set; }
        public IdLabel() { }
        public IdLabel(int id, string label)
        {
            Id = id;
            Label = label;
        }
    }
}
