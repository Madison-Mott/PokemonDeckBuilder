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
            else if (questionResult == "sm2-140")
            {
                deckChoice = "SylveonDeck";
                card = await SylveonDeck("sm2-140");
            }

            return View(deckChoice, card);
        }

        public async Task<PokemonCard> VaporeonDeck(string cardName)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?name={cardName}");

            PokemonCard PokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                PokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return PokemonInfo;
        }
                
        public async Task<PokemonCard> JolteonDeck(string cardName)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?name={cardName}");

            PokemonCard PokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                PokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return PokemonInfo;
        }
        
        public async Task<PokemonCard> FlareonDeck(string cardName)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?name={cardName}");

            PokemonCard PokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                PokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return PokemonInfo;
        }

        public async Task<PokemonCard> SylveonDeck(string id)
        {
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?id={id}");

            PokemonCard PokemonInfo = new PokemonCard();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<JObject>(cardResponse);
                var cards = responseObject.SelectToken("cards").ToObject<JArray>();
                var card = cards[0];
                PokemonInfo = JsonConvert.DeserializeObject<PokemonCard>(card.ToString());
            }
            return PokemonInfo;
        }

        public/* async Task<PokemonCard>*/ void ReturnFullDeck()
        {
            //list 
            //may be able to sort by card name and Id from API, just need to find out exactly which cards are in those gx decks 
        }
    }
}