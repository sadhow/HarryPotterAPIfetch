using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HarryPotterAPIfetch.Models;
using Newtonsoft.Json;
using RestSharp;

namespace HarryPotterAPIfetch.Services
{
    public class HarryPotterService
    {
        private readonly string _apiBaseUrl = "https://hp-api.onrender.com/api";

        public List<Character> GetCharacters()
        {
            var client = new RestClient(_apiBaseUrl);
            var request = new RestRequest("characters", Method.Get);

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                
                return JsonConvert.DeserializeObject<List<Character>>(response.Content);
            }
            else
            {
                // Handle error
                return new List<Character>();
            }
        }
        public Character GetCharacterByName(string name)
        {
            var characters = GetCharacters();
            return characters?.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

    }
}