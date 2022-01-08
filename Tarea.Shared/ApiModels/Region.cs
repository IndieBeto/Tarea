using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Tarea.Shared.ApiModels
{
    public class Region
    {
        [JsonProperty("region")]
        public string Nombre { get; set; }

        [JsonProperty("comunas")]
        public ICollection<string> Comunas { get; set; }
    }
}
