﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Address:Model
    {
        private long Id { get; set; }
        private long ClientId { get; set; }     
        private string Line1 { get; set; }
        private string Line2 { get; set; }
        private string Line3 { get; set; }
        private string Line4 { get; set; }
        private string Line5 { get; set; }
    }
}