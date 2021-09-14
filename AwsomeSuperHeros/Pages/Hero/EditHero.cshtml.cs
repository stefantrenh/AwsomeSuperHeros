using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwsomeSuperHeros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AwsomeSuperHeros.Pages.Hero
{
    public class EditHeroModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public HeroModel Hero { get; set; }
        public void OnGet(int heroId)
        {
            Hero = HeroListModel.HeroList.Where(f => f.Id == heroId).FirstOrDefault();
        }

        public IActionResult OnPost()
        {
            //var tempHero = HeroListModel.HeroList.Where(f => f.Id == Hero.Id).FirstOrDefault();
            //tempHero.Id = Hero.Id;
            //tempHero.Name = Hero.Name;
            //tempHero.SecretIdentiy = Hero.SecretIdentiy;
            //tempHero.SuperPower = Hero.SuperPower;

            foreach (var hero in HeroListModel.HeroList)
            {
                if (hero.Id == Hero.Id)
                {
                    hero.Name = Hero.Name;
                    hero.SecretIdentiy = Hero.SecretIdentiy;
                    hero.SuperPower = Hero.SuperPower;
                }
            }

            return RedirectToPage("/Hero/SuperHeros");
        }
    }
}
