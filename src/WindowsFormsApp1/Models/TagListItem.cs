﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class TagListItem
    {
        public String Tag { get; set; }
        public Int32 TotalPosts { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ({1})", Tag, TotalPosts);
        }
    }
}
