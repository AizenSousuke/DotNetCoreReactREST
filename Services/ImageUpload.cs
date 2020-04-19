using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using System.Net;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Services
{
    public class ImageUpload
    {
        private readonly string placeholder = "https://via.placeholder.com/150";

        private readonly string clientId = "ea30be65cb915f5";

        public async Task<string> Upload(string clientPathToImage)
        {
            try
            {
                using (WebClient webclient = new WebClient())
                {
                    var client = new ImgurClient(clientId);
                    var endpoint = new ImageEndpoint(client);

                    using (var stream = await webclient.OpenReadTaskAsync(clientPathToImage))
                    {
                        IImage image = await endpoint.UploadImageStreamAsync(stream);
                        return image.Link;
                    }
                }
            }
            catch { }

            return placeholder;
        }
    }
}