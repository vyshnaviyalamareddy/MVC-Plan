﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Plan.Models
{
    public class DegreePlanTermRequirement
    {
        public int DegreePlanID { get; set; }

        public int TermID { get; set; }

        public int RequirementID { get; set; }
    }
}
