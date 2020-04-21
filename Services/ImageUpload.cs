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


        /// <summary>
        /// Uploads image to Imgur using Imgur API. Returns The URL of uploaded image file on Imgur; returns placeholder URL if filepath is null or Imgur API failed.
        /// </summary>
        /// <param name="filepath">File path of image to upload.</param>
        /// <returns>The URL of uploaded image file on Imgur.</returns>
        public async Task<string> Upload(string filepath)
        {
            try
            {
                using (WebClient webclient = new WebClient())
                {
                    var client = new ImgurClient(clientId);
                    var endpoint = new ImageEndpoint(client);

                    using (var stream = await webclient.OpenReadTaskAsync(filepath))
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