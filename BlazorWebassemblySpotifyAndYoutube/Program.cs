using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SpotifyApi.NetCore;

namespace BlazorWebassemblySpotifyAndYoutube
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            Globals.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            builder.Services.AddSingleton(new HttpClient { BaseAddress = Globals.BaseAddress });
            builder.Services.AddSingleton(typeof(IPlaylistsApi), typeof(PlaylistsApi));
            builder.Services.AddSingleton(typeof(IUsersProfileApi), typeof(UsersProfileApi));
            builder.Services.AddSingleton(typeof(IFollowApi), typeof(FollowApi));
            builder.Services.AddSingleton(typeof(ISearchApi), typeof(SearchApi));
            builder.Services.AddSingleton(typeof(IPlayerApi), typeof(PlayerApi));

            await builder.Build().RunAsync();
        }
    }
}
