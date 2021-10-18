using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace App_world_Covid_FPSM_RAAM
{
     public class Model
    {
        [JsonProperty("Active Cases_text", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveCasesText { get; set; }

        [JsonProperty("Country_text", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryText { get; set; }

        [JsonProperty("Last Update", NullValueHandling = NullValueHandling.Ignore)]
        public string  LastUpdate { get; set; }

        [JsonProperty("New Cases_text", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCasesText { get; set; }

        [JsonProperty("New Deaths_text", NullValueHandling = NullValueHandling.Ignore)]
        public string NewDeathsText { get; set; }

        [JsonProperty("Total Cases_text", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalCasesText { get; set; }

        [JsonProperty("Total Deaths_text", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalDeathsText { get; set; }

        [JsonProperty("Total Recovered_text", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRecoveredText { get; set; }
    }
}
