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
        [BindProperty]
        public HeroModel Hero { get; set; }
        public void OnGet()
        {

        }
    }
}
