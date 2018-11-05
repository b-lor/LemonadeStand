using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int randomDay;
        public string acutalWeather;
        public int randomTemperature;

        public Weather()
        {
            randomDay = 0;
            randomTemperature = 0;
        }

        private void ChangeWeather()
        {
            Random rnd = new Random();
            randomDay = rnd.Next(3);
            DisplayWeather(randomDay);

        }

        private string DisplayWeather(int randomDay)
        {
            if (randomDay == 0)
            {
                acutalWeather = "Rain";
            }
            else if (randomDay == 1)
            {
                acutalWeather = "Cloudy";
            }
            else if (randomDay == 2)
            {
                acutalWeather = "Sunny";
            }
            return acutalWeather;

        }

        private void DisplayTemperature()
        {
            Random rnd = new Random();
            randomTemperature = rnd.Next(40, 90);

        }

        public void ActualWeather()
        {
            ChangeWeather();
            DisplayTemperature();

        }
    }
        
}
