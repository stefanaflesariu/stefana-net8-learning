﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class ConstructionTask
    {
        public ConstructionTask( string name, int duration) {
            
            Name = name;
            Duration = duration;
        }
        public string Name { get; set; }
        public int Duration { get; set; }
    }
}
