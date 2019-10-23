using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public IActionResult UserDeckChoice(string questionResult)
        {
            if (questionResult == "vaporeon-gx")
            {
                PokemonCard cardName = new PokemonCard
                {
                    PokemonName = questionResult
                };
                return View("VaporeonDeck", cardName);
            }
            else if (questionResult == "Jolteon")
            {
                return View("JolteonDeck");
            }
            else if (questionResult == "Flareon")
            {
                return View("FlareonDeck");
            }

            return View();

        }

        public async Task<IActionResult> VaporeonDeck(PokemonCard cardName)
        { 
            _client.BaseAddress = new Uri("https://api.pokemontcg.io/v1/");
            HttpResponseMessage response = await _client.GetAsync($"cards?name={cardName}");

            List<PokemonCard> PokemonInfo = new List<PokemonCard>();

            if (response.IsSuccessStatusCode)
            {
                var cardResponse = response.Content.ReadAsStringAsync().Result;

                PokemonInfo = JsonConvert.DeserializeObject<List<PokemonCard>>(cardResponse);
            }
            return View(PokemonInfo);
        }

        public IActionResult JolteonDeck()
        {
            return View();
        }

        public IActionResult FlareonDeck()
        {
            return View();
        }

    }
}