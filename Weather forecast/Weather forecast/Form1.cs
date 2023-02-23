using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;



namespace Weather_forecast
{
    public partial class Form1 : Form
    {

        public class MyIp
        {
            public string ip { get; set; }
        }

        public class MyGeo
        {
            public string city { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public float lat { get; set; }
            public float lon { get; set; }
           


        }

        public class WeatherForecast
        {
            public float elevation { get; set; }
            public current_weather_class current_weather { get; set; }
         

        }

        public class current_weather_class
        {
            public float temperature { get; set; }
            public float windspeed { get; set; }
            public float winddirection { get; set; }
            public float weathercode { get; set; }
        }

        public string MyIPPublicString;
        public string country_name_publicString;
        public string region_publicString;
        public string city_publicString;
        public string lat_publicString;
        public string lon_publicString;

        public string elevation_publicString;
        public string temperature_publicString;
        public string windspeed_publicString;
        public string winddirection_publicString;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region Get_IP
            string uri;
            string ResultIPString;

            uri = "https://api.ipify.org?format=json";
            ResultIPString = GetMyIP(uri);

            MyIp myip = JsonSerializer.Deserialize<MyIp>(ResultIPString);
            MyIPPublicString = myip.ip;
            YouIpLabel.Text = "Your IP: " + MyIPPublicString;
            #endregion

            #region Get_geopisition
            string JsonAnswerString;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpWebRequest request               = (HttpWebRequest)WebRequest.Create("http://ip-api.com/json/"+MyIPPublicString);
            request.UserAgent                    = "ipapi.co/#c-sharp-v1.03";
            HttpWebResponse response             = (HttpWebResponse)request.GetResponse();
            var reader                           = new System.IO.StreamReader(response.GetResponseStream(), UTF8Encoding.UTF8);
            JsonAnswerString                     = reader.ReadToEnd();

            MyGeo mygeo               = JsonSerializer.Deserialize<MyGeo>(JsonAnswerString);
            country_name_publicString = mygeo.country;
            region_publicString       = mygeo.region;
            city_publicString         = mygeo.city;
            lat_publicString          = mygeo.lat.ToString("00.00");
            lon_publicString          = mygeo.lon.ToString("00.00");

            lat_publicString = lat_publicString.Replace(",", ".");
            lon_publicString = lon_publicString.Replace(",", ".");

            country_name.Text = "Country: " + country_name_publicString;
            region.Text       = "Region: " + region_publicString;
            city.Text         = "Сity: " + city_publicString;
            latitude.Text     = "Latitude: " + lat_publicString;
            longitude.Text    = "Longitude: " + lon_publicString;

            #endregion

            #region Forecast
            string ResultForecasrString;

            uri = "https://api.open-meteo.com/v1/forecast?latitude=" + lat_publicString + "&longitude=" + lon_publicString + "&current_weather=true";
            ResultForecasrString = GetMyIP(uri);
            
            WeatherForecast weatherforecast = JsonSerializer.Deserialize<WeatherForecast>(ResultForecasrString);

            elevation_publicString     = weatherforecast.elevation.ToString();
            temperature_publicString   = weatherforecast.current_weather.temperature.ToString();
            windspeed_publicString     = weatherforecast.current_weather.windspeed.ToString();
            winddirection_publicString = weatherforecast.current_weather.winddirection.ToString();

            elevation.Text       = "Elevation: " + elevation_publicString;
            temperature.Text     = "Temperature: " + temperature_publicString;
            windspeed.Text       = "WindSpeed: " + windspeed_publicString;
            winddirection.Text   = "WindDirection: " + winddirection_publicString;


            #endregion




        }

    public string GetMyIP(string uri)
        {
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
