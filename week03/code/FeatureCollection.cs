using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
public class FeatureCollection
{
   public class EarthquakeData
{
    public List<Feature> features { get; set; }
}

public class Feature
{
    public Properties properties { get; set; }
}

public class Properties
{
    public double? mag { get; set; } // Puede ser null, por eso usamos double?
    public string place { get; set; }
}

   

    
   public class EarthquakeService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<string[]> EarthquakeDailySummary()
        {
            string url = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
            string json = await client.GetStringAsync(url);

            EarthquakeData data = JsonConvert.DeserializeObject<EarthquakeData>(json);

            List<string> summaries = new List<string>();
            foreach (var feature in data.features)
            {
                string summary = $"{feature.properties.place} - Magnitude: {feature.properties.mag}";
                summaries.Add(summary);
            }

            return summaries.ToArray();
        }
    }
}
