﻿using System;

namespace WeatherApp
{
    public class HistoryRecord
    {
        public string Location { get; set; }
        public double Temperature { get; set; }
        public string Conditions { get; set; }

        public DateTime Date { get; set; }

    }
}
