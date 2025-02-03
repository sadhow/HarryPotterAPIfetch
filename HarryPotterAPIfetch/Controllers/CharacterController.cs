using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HarryPotterAPIfetch.Models;
using HarryPotterAPIfetch.Services;

namespace HarryPotterAPIfetch.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        private readonly HarryPotterService _harryPotterService = new HarryPotterService();
        
        public ActionResult Index()
        {
            var characters = _harryPotterService.GetCharacters();
            return View(characters);
        }


        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string characterName)
        {
            var character = _harryPotterService.GetCharacterByName(characterName);
            return View("SearchResults", character);
        }

        public ActionResult SearchResults(Character character)
        {
            return View(character); // Display the character details
        }
    }
}