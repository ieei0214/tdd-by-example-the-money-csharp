﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_by_example_the_money_csharp
{
    public interface Expression
    {
        public Money reduce(string to);
    }
}
