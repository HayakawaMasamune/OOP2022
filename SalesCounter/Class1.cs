﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class SalesCounter {
        private List<Sale> _sales;

        public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }
    }
}
