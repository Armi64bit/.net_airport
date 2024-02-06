﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class  Staff : Passenger
    {
        public string Function { get; set; }
        public int Salary { get; set; }
        public DateTime EmployementDate { get; set; }

        public override string ToString()
        {
            return base.ToString+ "Salary: " + Salary
                + ";" + "EmployementDate: " + EmployementDate
                + ";" + "Function: " + Function;
        }
        public string GetPassengerType()
        {
            return " « I am a passenger I am a Staff Member";
        }

    }
}
