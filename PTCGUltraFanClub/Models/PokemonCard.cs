using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTCGUltraFanClub.Models
{
    
    public class Rootobject
    {
        //[JsonProperty("card")]
        public PokemonCard pokemonCard { get; set; } //renamed from Card card
    }

    //renamed this from Card
    public class PokemonCard
    {
        [JsonProperty("id")]
        public string PokemonCardId { get; set; }

        [JsonProperty("name")]
        public string PokemonName { get; set; }

        [JsonProperty("nationalPokedexNumber")]
        public int NationalPokedexNumber { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("imageUrlHiRes")]
        public string ImageUrlHiRes { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }

        [JsonProperty("supertype")]
        public string SuperType { get; set; }

        [JsonProperty("subtype")]
        public string SubType { get; set; }

        [JsonProperty("evolvesFrom")]
        public string EvolvesFrom { get; set; }

        [JsonProperty("ability")]
        public Ability Ability { get; set; }

        [JsonProperty("hp")]
        public string HP { get; set; }

        [JsonProperty("retreatCost")]
        public string[] RetreatCost { get; set; }

        [JsonProperty("convertedRetreatCost")]
        public int ConvertedRetreatCost { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("series")]
        public string Series { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("setCode")]
        public string SetCode { get; set; }

        [JsonProperty("attacks")]
        public Attack[] Attacks { get; set; }

        [JsonProperty("weaknesses")]
        public Weakness[] Weaknesses { get; set; }
    }

    public class Ability
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Attack
    {
        [JsonProperty("cost")]
        public string[] Cost { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }

        [JsonProperty("convertedEnergyCost")]
        public int ConvertedEnergyCost { get; set; }
    }

    public class Weakness
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }

}
