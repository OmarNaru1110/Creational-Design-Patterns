﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class Duck : IAnimal
    {
        public string GetAnimal() => "Duck";
    }
}
