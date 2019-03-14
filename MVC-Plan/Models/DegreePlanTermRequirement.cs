﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Plan.Models
{
    public class DegreePlanTermRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanTermRequirementID { get; set; }

        public int TermID { get; set; }

        public int RequirementID { get; set; }
    }
}
