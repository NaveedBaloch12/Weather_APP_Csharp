using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public partial class FormMain : Form
    {
        private static readonly string apiKey = "f751a54ad113cf4c755b29174696669a";
        private static readonly string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units={2}";

        string weather, temperatureCelsius, temperatureFahrenheit, windSpeedMetric, windSpeedImperial, humidity;
        bool TempInCenti = true;

        public FormMain()
        {
            InitializeComponent();
        }

        #region Weather APIs Functions

        private async Task LoadWeatherAsync(string cityName)
        {
            string urlMetric = string.Format(apiUrl, cityName, apiKey, "metric");
            string urlImperial = string.Format(apiUrl, cityName, apiKey, "imperial");

            using (HttpClient client = new HttpClient())
            {
                // Get weather data in Celsius
                HttpResponseMessage responseMetric = await client.GetAsync(urlMetric);
                HttpResponseMessage responseImperial = await client.GetAsync(urlImperial);

                if (responseMetric.IsSuccessStatusCode && responseImperial.IsSuccessStatusCode)
                {
                    string responseBodyMetric = await responseMetric.Content.ReadAsStringAsync();
                    string responseBodyImperial = await responseImperial.Content.ReadAsStringAsync();

                    JObject weatherDataMetric = JObject.Parse(responseBodyMetric);
                    JObject weatherDataImperial = JObject.Parse(responseBodyImperial);

                    weather = weatherDataMetric["weather"][0]["description"].ToString();
                    temperatureCelsius = weatherDataMetric["main"]["temp"].ToString();
                    temperatureFahrenheit = weatherDataImperial["main"]["temp"].ToString();
                    windSpeedMetric = weatherDataMetric["wind"]["speed"].ToString();
                    windSpeedImperial = weatherDataImperial["wind"]["speed"].ToString();
                    humidity = weatherDataMetric["main"]["humidity"].ToString();

                    UpdateGUI();
                    UpdatePictures(weather);
                }
                else
                {
                    MessageBox.Show("Error: Unable to fetch weather data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Search For Weather

        private void btnSearchCity_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCityName.Text))
            {
                string cityName = txtCityName.Text;
                LoadWeatherAsync(cityName);
            }
            else
            {
                MessageBox.Show("Enter City Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Update GUI

        private void UpdateGUI()
        {
            lbDayTime.Text = Convert.ToString(DateTime.Now);

            if (TempInCenti == true)
            {
                lbTemp.Text = temperatureCelsius;
            }
            else
            {
                lbTemp.Text = temperatureFahrenheit;
            }

            lbWeatherStatus.Text = weather;
            lbHumidity.Text = humidity;
            lbWindSpeed.Text = $"{windSpeedMetric} m/s / {windSpeedImperial} mph";
        }

        private void UpdatePictures(string Weather)
        {
            if (Weather.Contains("Clear", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.Sun;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.Sun;
            }
            else if (Weather.Contains("Clouds", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.Cloud;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.Cloud;
            }
            else if (Weather.Contains("Rain", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.Rain;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.Rain;
            }
            else if (Weather.Contains("Thunderstorm", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.Cloud_Lighting;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.Cloud_Lighting;
            }
            else if (Weather.Contains("Snow", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.SnowFall;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.SnowFall;
            }
            else if (Weather.Contains("Mist", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.mist;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.mist;
            }
            else if (Weather.Contains("Drizzle", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.drizzle;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.drizzle;
            }
            else if (Weather.Contains("Fog", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.smoke;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.smoke;
            }
            else if (Weather.Contains("smoke", StringComparison.OrdinalIgnoreCase))
            {
                pbLargeWeather.Image = WeatherApp.Properties.Resources.smoke;
                pbSmallWeather.Image = WeatherApp.Properties.Resources.smoke;
            }
        }

        #endregion

        #region Sawap Temperature

        private void lbDegCenti_Click(object sender, EventArgs e)
        {
            TempInCenti = true;

            lbDegCenti.ForeColor = Color.White;
            ldDegFren.ForeColor = Color.Gainsboro;

            lbTemp.Text = temperatureCelsius;
        }

        private void ldDegFren_Click(object sender, EventArgs e)
        {
            TempInCenti = false;

            lbDegCenti.ForeColor = Color.Gainsboro;
            ldDegFren.ForeColor = Color.White;

            lbTemp.Text = temperatureFahrenheit;
        }

        #endregion
    }
}
