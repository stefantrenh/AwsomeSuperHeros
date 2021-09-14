using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwsomeSuperHeros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AwsomeSuperHeros.Pages.Hero
{
    public class RemoveHeroModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public HeroModel Hero { get; set; }
        public IActionResult OnGet(int heroId)
        {
            Hero = HeroListModel.HeroList.Where(f => f.Id == heroId).FirstOrDefault();
            foreach (var hero in HeroListModel.HeroList)
            {
                if (hero.Id == Hero.Id)
                {
                    HeroListModel.HeroList.Remove(hero);
                    return RedirectToPage("/Hero/SuperHeros");
                }
            }

            return RedirectToPage("/Hero/SuperHeros");

        }
    }
}
