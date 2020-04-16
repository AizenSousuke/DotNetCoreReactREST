using System.Threading.Tasks;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using Imgur.API;
using Serilog;
using System.Net;

namespace DotNetCoreReactREST.Services
{
    public class ImageUpload
    {
        private readonly string ClientID = "ea30be65cb915f5";
        private readonly string ClientSecret = "508f84defc102be0c5696692e37cd172f9676fab";

        public async Task<string> Upload(string clientPathToImage)
        {
            try
            {
                using (WebClient webclient = new WebClient())
                {
                    var client = new ImgurClient(ClientID, ClientSecret);
                    var endpoint = new ImageEndpoint(client);
                    IImage image;

                    using (var stream = await webclient.OpenReadTaskAsync(clientPathToImage))
                    {
                        image = await endpoint.UploadImageStreamAsync(stream);
                    }
                    Log.Information($"Image uploaded. Url: {image.Link}");
                    return image.Link;
                }
            }
            catch (ImgurException imgurEx)
            {
                Log.Information($"ImageUpload Exception: {imgurEx}");
            }
            return "https://via.placeholder.com/150";
        }


    }
}
