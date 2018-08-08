using System;
using Newtonsoft.Json;

namespace Taurit.Config.Catalog.Models.HealthyMealPlanner
{
    public class SoftwareVersionInformation
    {
        [Obsolete("Do not use unless you are a deserializer")]
        private SoftwareVersionInformation()
        {
        }

        public SoftwareVersionInformation(Version version)
        {
            Version = version;
        }

        [JsonProperty] public Version Version { get; private set; }
    }
}