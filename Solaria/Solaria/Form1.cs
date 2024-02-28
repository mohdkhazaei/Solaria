// Student ref. 10769575
// Module - SOFT050

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using Newtonsoft.Json;
using System.Net;

namespace Solaria
{
    public partial class Form1 : Form
    {
        // Connection string to connect to the SQL database
        private string connectionString = "Server=MOHAMMADS-PC\\SQLEXPRESS;Database=solaria;User Id=user;Password=user;";

        // API key for OpenWeatherMap API
        string APIkey = "668c441bcb95dac2207cc1dae535cca0";

        // Constructor for Form1 class
        public Form1()
        {
            // Initialize the form components
            InitializeComponent();

            // Set up auto-complete behavior for the text box
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the text box has any content
            if (textBox.Text.Length > 0)
            {
                try
                {
                    // Create a connection to the SQL database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Define the SQL query to search for city names
                        string query = "SELECT cityName FROM suggestions WHERE cityName LIKE @searchTerm ORDER BY cityName;";

                        // Create the search term with wildcard characters
                        var searchTerm = $"%{textBox.Text}%";

                        // Execute the query and store the results
                        var suggestions = connection.Query<string>(query, new { searchTerm = searchTerm });

                        // Set up the auto-complete custom source with the query results
                        textBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                        textBox.AutoCompleteCustomSource.AddRange(suggestions.ToArray());
                    }

                }
                catch (Exception ex)
                {
                    // Display an error message and log the exception details
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cityName = textBox.Text;

            // Check if the city name is not empty
            if (!string.IsNullOrEmpty(cityName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Define the SQL query to get city information
                    string query = "SELECT TOP 1 * FROM suggestions WHERE cityName = @cityName;";

                    // Execute the query and store the result
                    var city = connection.QueryFirstOrDefault<dynamic>(query, new { cityName });

                    // Check if the city was found in the database
                    if (city != null)
                    {
                        // Get the latitude and longitude of the city
                        double latitude = double.Parse(city.lat);
                        double longitude = double.Parse(city.lon);

                        // Fetch weather data for the city
                        getWeather(latitude, longitude);
                    }
                    else
                    {
                        // Display an error message if the city was not found or has missing coordinates
                        MessageBox.Show("City not found or missing coordinates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Asynchronous method to fetch weather data for a given location
        // This method takes latitude and longitude as input and updates the UI with the fetched weather data
        async void getWeather(double lat, double lon)
        {
            try
            {
                // Create an HttpClient for making API requests
                using (HttpClient client = new HttpClient())
                {
                    // Build the request URL with the latitude, longitude, and API key
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid={2}", lat, lon, APIkey);

                    // Send an HTTP GET request to the API
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Read the content of the response as a string
                    string content = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON content into a weatherInfo.root object
                    weatherInfo.root? Info = JsonConvert.DeserializeObject<weatherInfo.root>(content);

                    // Update the location label with the city name
                    locationLabel.Text = textBox.Text;

                    // Check if the weather data is available and update the UI
                    if (Info != null && Info.weather != null && Info.weather.Count > 0)
                    {
                        pictureBox.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                        curWatherLabel.Text = Info.weather[0].main;
                    }

                    // Check if the main weather data is available and update the UI
                    if (Info != null && Info.main != null)
                    {
                        curTempLabel.Text = Math.Round(KelvinToCelsius(Info.main.temp)).ToString() + "°C";
                        tempMax.Text = Math.Round(KelvinToCelsius(Info.main.temp_max)).ToString() + "°C";
                        tempMin.Text = Math.Round(KelvinToCelsius(Info.main.temp_min)).ToString() + "°C";
                        humidityLabel.Text = Info.main.humidity.ToString() + "%";
                        feelsLikeLabel.Text = Math.Round(KelvinToCelsius(Info.main.feels_like)).ToString() + "°C";
                        pressureLabel.Text = Info.main.pressure.ToString() + " " + "hPa";
                    }

                    // Check if the wind data is available and update the UI
                    if (Info != null && Info.wind != null)
                    {
                        windSpeedLabel.Text = Info.wind.speed.ToString() + "m/s";
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle exceptions related to the API call
                MessageBox.Show($"An error occurred while fetching weather data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                // Handle exceptions related to JSON deserialization
                MessageBox.Show($"An error occurred while processing weather data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions that may occur
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Helper method to convert Kelvin temperatures to Celsius
        private double KelvinToCelsius(double kelvinTemp)
        {
            return kelvinTemp - 273.15;
        }

    }
}





