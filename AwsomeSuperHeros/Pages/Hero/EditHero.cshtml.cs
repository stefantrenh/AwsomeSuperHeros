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

        public void OnPost()
        {
            var tempHero = HeroListModel.HeroList.Where(f => f.Id == Hero.Id).FirstOrDefault();
            tempHero.Id = Hero.Id;
            tempHero.Name = Hero.Name;
            tempHero.SecretIdentiy = Hero.SecretIdentiy;
            tempHero.SuperPower = Hero.SuperPower;

            var dict = HeroListModel.HeroList.ToDictionary(x => x.Id);

            if (dict.TryGetValue(myValue, out found)) found.OtherProperty = newValue;
        }
    }
}
