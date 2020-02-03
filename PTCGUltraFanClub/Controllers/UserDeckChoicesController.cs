using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PTCGUltraFanClub.Models;

namespace PTCGUltraFanClub.Controllers
{
    public class UserDeckChoicesController : Controller
    {
        private readonly HttpClient _client;
        private readonly PTCGUltraFanClubContext _PTCGUltraFanClubContext;

        public UserDeckChoicesController(IHttpClientFactory httpClientFactory, PTCGUltraFanClubContext pTCGUltraFanClubContext)
        {
            _client = httpClientFactory.CreateClient();
            _PTCGUltraFanClubContext = pTCGUltraFanClubContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserDeckChoice()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserDeckChoice(string questionResult)
        {
            var (deckChoice, card) = ("", new PokemonCard());

            if (questionResult == "vaporeon-gx")
            {
                deckChoice = "VaporeonDeck";
                card = await VaporeonDeck("vaporeon-gx");
            }
            else if (questionResult == "jolteon-gx")
            {
                deckChoice = "JolteonDeck";
                card = await JolteonDeck("jolteon-gx");
            }
            else if (questionResult == "flareon-gx")
            {
                deckChoice = "FlareonDeck";
                card = await FlareonDeck("flareon-gx");
            }
            else if (questionResult == "sm1-152")
            {
                deckChoice = "EspeonDeck";
                card = await EspeonDeck("sm1-152");
            }
            else if (questionResult == "sm1-154")
            {
                deckChoice = "UmbreonDeck";
                card = await UmbreonDeck("sm1-154");
            }
            else if (questionResult == "sm2-158")
            {
                deckChoice = "SylveonDeck";
                card = await SylveonDeck("sm2-158");
            }
            else if (questionResult == "sm5-157")
            {
                deckChoice = "LeafeonDeck";
                card = await LeafeonDeck("sm5-157");
            }
            else if (questionResult == "sm5-159")
            {
                deckChoice = "GlaceonDeck";
                card = await GlaceonDeck("sm5-159");
            }

            return View(deckChoice, card);
        }

        public async Task<PokemonCard> VaporeonDeck(string cardName)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?name={cardName}");

            PokemonCard pokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                pokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return pokemonInfo;
        }

        public async Task<PokemonCard> JolteonDeck(string cardName)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?name={cardName}");

            PokemonCard pokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                pokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return pokemonInfo;
        }

        public async Task<PokemonCard> FlareonDeck(string cardName)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?name={cardName}");

            PokemonCard pokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                pokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return pokemonInfo;
        }
        public async Task<PokemonCard> EspeonDeck(string id)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?id={id}");

            PokemonCard pokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                pokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return pokemonInfo;
        }
        public async Task<PokemonCard> UmbreonDeck(string id)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?id={id}");

            PokemonCard pokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                pokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return pokemonInfo;
        }
        public async Task<PokemonCard> SylveonDeck(string id)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?id={id}");

            PokemonCard pokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                pokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return pokemonInfo;
        }
        public async Task<PokemonCard> LeafeonDeck(string id)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?id={id}");

            PokemonCard pokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                pokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return pokemonInfo;
        }
        public async Task<PokemonCard> GlaceonDeck(string id)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?id={id}");

            PokemonCard pokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                pokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return pokemonInfo;
        }

        public/* async Task<PokemonCard>*/ void ReturnFullDeck()
        {
            //list
            //may be able to sort by card name and Id from API, just need to find out exactly which cards are in those gx decks
        }
    }
}