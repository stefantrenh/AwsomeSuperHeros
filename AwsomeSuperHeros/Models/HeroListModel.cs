using System;
using System.Collections.Generic;
using System.Linq;
using AwsomeSuperHeros.Api;
using System.Threading.Tasks;

namespace AwsomeSuperHeros.Models
{
    public static class HeroListModel
    {
        public static List<HeroModel> HeroList { get; set; } = new List<HeroModel>();

       

        public static void Init()
        {
            HeroList.Add(new HeroModel { Name = "Steffe", SecretIdentiy = "Kinapuffen", SuperPower = "Påkerfejs", Id = 1, ImgUrl = ImagesProcessor.LoadImage().Result.Results[0].Picture.Large });
            HeroList.Add(new HeroModel { Name = "Posse", SecretIdentiy = "Ankan", SuperPower = "Kvack", Id = 2, ImgUrl = ImagesProcessor.LoadImage().Result.Results[0].Picture.Large });
            HeroList.Add(new HeroModel { Name = "Simoon", SecretIdentiy = "Simpan", SuperPower = "Öl Drickarn", Id = 3, ImgUrl = ImagesProcessor.LoadImage().Result.Results[0].Picture.Large });
            HeroList.Add(new HeroModel { Name = "Gustav Vasa", SecretIdentiy = "Nestor", SuperPower = "Katt Slav", Id = 4, ImgUrl = ImagesProcessor.LoadImage().Result.Results[0].Picture.Large });
        }
    }
}
