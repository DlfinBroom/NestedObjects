﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects {
    class Student {
        public string Name { get; set; }
        public DateTime? DOB { get; set; }

        public Advisor AssignedAdvisor { get; set; }
    }
}
