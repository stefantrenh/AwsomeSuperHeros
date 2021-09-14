using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwsomeSuperHeros.Models
{
    public static class HeroListModel
    {
        public static List<HeroModel> HeroList { get; set; } = new List<HeroModel>();

       

        public static void Init()
        {
            HeroList.Add(new HeroModel { Name = "Steffe", SecretIdentiy = "Kinapuffen", SuperPower = "Påkerfejs", Id = 1 });
            HeroList.Add(new HeroModel { Name = "Posse", SecretIdentiy = "Ankan", SuperPower = "Kvack", Id = 2 });
            HeroList.Add(new HeroModel { Name = "Simoon", SecretIdentiy = "Simpan", SuperPower = "Öl Drickarn", Id = 3 });
        }
    }
}
