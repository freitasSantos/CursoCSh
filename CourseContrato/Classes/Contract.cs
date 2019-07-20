﻿using System;
using System.Globalization;


namespace CourseContrato.Classes {
    class Contract {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public Contract() {
        }

        public Contract(DateTime date,double valuePerHour,int hour) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        public double totalValue() {
            return ValuePerHour * Hour;
        }

    }
}
