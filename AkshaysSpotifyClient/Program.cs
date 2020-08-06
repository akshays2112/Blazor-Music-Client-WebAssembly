using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SpotifyApi.NetCore;

namespace AkshaysSpotifyClient
{
    public class Program
    {
        public static SpotifyAccessToken SpotifyAccessToken;
        public static GoogleApisYoutubeAccessToken GoogleApisYoutubeAccessToken;
        public static string GoogleApisApiKey = "Put GoogleApis Youtube Api Key string in here";
        public static string BaseHostUriString;

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            BaseHostUriString = builder.HostEnvironment.BaseAddress;
            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(BaseHostUriString) });
            builder.Services.AddSingleton(typeof(IPlaylistsApi), typeof(PlaylistsApi));
            builder.Services.AddSingleton(typeof(IUsersProfileApi), typeof(UsersProfileApi));
            builder.Services.AddSingleton(typeof(IFollowApi), typeof(FollowApi));

            await builder.Build().RunAsync();
        }
    }
}
