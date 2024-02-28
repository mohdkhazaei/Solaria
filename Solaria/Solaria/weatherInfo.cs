using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Solaria namespace contains all the classes related to the Solaria project
namespace Solaria
{
    // The weatherInfo class contains nested classes that represent weather information
    internal class weatherInfo
    {
        // The coord class represents geographic coordinates (longitude and latitude)
        public class coord
        {
            public double lon { get; set; } // Longitude value
            public double lat { get; set; } // Latitude value
        }

        // The weather class represents weather condition information
        public class weather
        {
            public string? main { get; set; }        // Main weather condition (e.g. Rain, Clear, etc.)
            public string? icon { get; set; }        // Icon identifier for the weather condition
        }

        // The main class represents temperature and atmospheric information
        public class main
        {
            public double temp { get; set; }       // Current temperature
            public double feels_like { get; set; }  // "Feels like" temperature
            public double temp_min { get; set; }    // Minimum temperature
            public double temp_max { get; set; }    // Maximum temperature
            public double pressure { get; set; }   // Atmospheric pressure
            public double humidity { get; set; }   // Humidity percentage
        }

        // The wind class represents wind-related information
        public class wind
        {
            public double speed { get; set; } // Wind speed
        }

        // The root class is the top-level container for all the weather information
        public class root
        {
            public coord? coord { get; set; }                // Geographic coordinates
            public List<weather>? weather { get; set; }      // List of weather conditions
            public main? main { get; set; }                  // Temperature and atmospheric information
            public wind? wind { get; set; }                  // Wind information
        }
    }
}
