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
        public int DegreePlanID { get; set; }

        public int TermID { get; set; }

        public int RequirementID { get; set; }


        public DegreePlan DegreePlan { get; set; }
        public Requirement Requirement { get; set; }
    }
}
