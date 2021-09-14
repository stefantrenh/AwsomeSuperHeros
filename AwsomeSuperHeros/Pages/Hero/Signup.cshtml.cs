using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwsomeSuperHeros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AwsomeSuperHeros.Pages.Hero
{
    public class SignupModel : PageModel
    {
        [BindProperty]
        public HeroModel Hero { get; set; }

 
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Hero.Id = HeroListModel.HeroList.LastOrDefault().Id + 1;
            HeroListModel.HeroList.Add(Hero);

            return RedirectToPage("/Hero/SuperHeros");
        }

    }
}
