using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwsomeSuperHeros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AwsomeSuperHeros.Pages.Hero
{
    public class SuperHerosModel : PageModel
    {
        public List<HeroModel> HeroList { get; set; } = HeroListModel.HeroList;
        public void OnGet()
        {

        }
    }
}
