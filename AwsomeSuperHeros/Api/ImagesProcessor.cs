using AwsomeSuperHeros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AwsomeSuperHeros.Api
{
    public class ImagesProcessor
    {
        public static async Task<ApiModel> LoadImage()
        {
            string url = ApiHelper.ApiClient.BaseAddress.ToString();

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ApiModel image = await response.Content.ReadAsAsync<ApiModel>();

                    return image;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
