using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTCGUltraFanClub.Models
{
    
    public class Rootobject
    {
        public PokemonCard pokemonCard { get; set; } 
    }


    public class PokemonCard
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int NationalPokedexNumber { get; set; }

        public string ImageUrl { get; set; }

        public string ImageUrlHiRes { get; set; }

        public string[] Types { get; set; }

        public string SuperType { get; set; }

        public string SubType { get; set; }

        public string EvolvesFrom { get; set; }

        public Ability Ability { get; set; }

        public string HP { get; set; }

        public string[] RetreatCost { get; set; }

        public int ConvertedRetreatCost { get; set; }

        public string Number { get; set; }

        public string Artist { get; set; }

        public string Rarity { get; set; }

        public string Series { get; set; }

        public string Set { get; set; }

        public string SetCode { get; set; }

        public Attack[] Attacks { get; set; }

        public Weakness[] Weaknesses { get; set; }
    }

    public class Ability
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public string Type { get; set; }
    }

    public class Attack
    {
        public string[] Cost { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public string Damage { get; set; }

        public int ConvertedEnergyCost { get; set; }
    }

    public class Weakness
    {
        public string Type { get; set; }

        public string Value { get; set; }
    }

}
