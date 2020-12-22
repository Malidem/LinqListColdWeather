using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQListColdWeather3
{

    public enum DayOfWeek
    {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat
    }

    class program
    {
        static void Main()
        {

            var daysForecasted = new List<weather>
            {
                new weather ("Sun", 38, 34),
                new weather ("Mon", 39, 30),
                new weather ("Tue", 50, 33),
                new weather ("Wed", 34, 14),
                new weather ("Thu", 19, 16)
            };

            var ColdDays =
                from forecast in daysForecasted
                where forecast.HighTemp < 40
                select forecast;


            foreach (var weather in ColdDays)
            { 

                Console.WriteLine("Cold weather on {0}", weather.Day);
            }

        }
    }
    class weather
    {


        public string Day { get; set; }
        public int HighTemp { get; set; }
        public int LowTemp { get; set; }

        public weather(string day, int high, int low)
        {
            Day = day;
            HighTemp = high;
            LowTemp = low;
        }
    }
}
