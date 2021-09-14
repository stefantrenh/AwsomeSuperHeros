using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwsomeSuperHeros.Api;
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
            Hero.ImgUrl = ImagesProcessor.LoadImage().Result.Results[0].Picture.Large;
            if (HeroListModel.HeroList.Any())
            {
                Hero.Id = HeroListModel.HeroList.LastOrDefault().Id + 1;
            }
            else {
                Hero.Id = 1;
            }

            HeroListModel.HeroList.Add(Hero);


            return RedirectToPage("/Hero/SuperHeros");
        }

    }
}
