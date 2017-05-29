﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Bill : Model
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private Orders OrderInfo { get; set; }
        private DateTime BillSent { get; set; }
        private double Total { get; set; }
    }
}
