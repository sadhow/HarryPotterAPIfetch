using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace HarryPotterAPIfetch.Models
{
    public class Character
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alternate_names")]
        public List<string> AlternateNames { get; set; } = new List<string>();

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; } 

        [JsonProperty("yearOfBirth")]
        public int? YearOfBirth { get; set; } 

        [JsonProperty("wizard")]
        public bool Wizard { get; set; }

        [JsonProperty("ancestry")]
        public string Ancestry { get; set; }

        [JsonProperty("eyeColour")]
        public string EyeColour { get; set; }

        [JsonProperty("hairColour")]
        public string HairColour { get; set; }

        [JsonProperty("wand")]
        public Wand Wand { get; set; }

        [JsonProperty("patronus")]
        public string Patronus { get; set; }

        [JsonProperty("hogwartsStudent")]
        public bool HogwartsStudent { get; set; }

        [JsonProperty("hogwartsStaff")]
        public bool HogwartsStaff { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("alternate_actors")]
        public List<string> AlternateActors { get; set; } = new List<string>();

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class Wand
    {
        [JsonProperty("wood")]
        public string Wood { get; set; }

        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("length")]
        public double? Length { get; set; }
    }
}