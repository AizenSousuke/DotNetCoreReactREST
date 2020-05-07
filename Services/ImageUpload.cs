using System.Net;
using System.Threading.Tasks;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using Serilog;

namespace DotNetCoreReactREST.Services
{
    public class ImageUpload
    {
        private const string ClientId = "ea30be65cb915f5";
        private const string Placeholder = "https://via.placeholder.com/150";

        /// <summary>
        /// Uploads image to Imgur using Imgur API. Returns the URL of uploaded image file on Imgur; returns placeholder URL if filepath is null or Imgur API failed.
        /// </summary>
        /// <param name="filepath">File path of image to upload.</param>
        /// <returns>The URL of uploaded image file on Imgur.</returns>
        public async Task<string> Upload(string filepath)
        {
            if (!string.IsNullOrEmpty(filepath))
            {
                Log.Information("Filepath: {@FilePath}", filepath);
                using (WebClient webclient = new WebClient())
                {
                    var client = new ImgurClient(ClientId);
                    var endpoint = new ImageEndpoint(client);

                    using (var stream = await webclient.OpenReadTaskAsync(filepath))
                    {
                        IImage image = await endpoint.UploadImageStreamAsync(stream);
                        if (image == null)
                        {
                            return Placeholder;
                        }

                        return image.Link;
                    }
                }
            }

            return Placeholder;
        }
    }
}