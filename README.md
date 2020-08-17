![Alt text](https://raw.githubusercontent.com/akshays2112/BlazorWebassemblySpotifyAndYoutube/master/Images/BlazorMusicClient.png?raw=true "Blazor Music Client")
# BlazorWebassemblySpotifyAndYoutube

[![License: MIT](https://img.shields.io/badge/license-MIT-yellow.svg)](#)
[![Twitter: AkshayS84661920](https://img.shields.io/twitter/follow/AkshayS84661920.svg?style=social)](https://twitter.com/AkshayS84661920)

> 🚀 A Blazor WebAssembly SPA (Single Page Application) in C# that is a client for Spotify and Google Youtube.

The purpose is to provide whatever I think of to make my life easier for using Spotify and Youtube and give this to everyone else too.

The purpose of Spotify is for audio only. The purpose for Youtube Music Vides is audio+video. So keeping this in mind both ways will be implemented. Since I started with figuring out the Spotify API endpoints first this side will be done first. Then everything done Spotify to Youtube will be done Youtube to Spotify.

## Blazor Music Client is not meant ever to replace Spotify and Youtube clients or mechanisms to consume music. It is only meant to augment features that are missing.

The following are implemented:
1) List all your Youtube Playlists.
2) Upon clicking a Youtube Playlists all the Videos in it are listed.
3) The processed title of the Youtube Video is then available in a textbox for editing.
4) You can search for the Spotify tracks/songs based on the contents of this text box.
5) A list is displayed of the Spotify song title and under it the artists for that song.
6) A list of buttons with the title of your Spotify playlist are provided which can be clicked on to add the song to the Spotify playlist.

Next upcoming features:
1) You can reorganize the returned list of songs by artists per search on the processed and edited Youtube video title.
2) On another page you will be able to search specifically by artist and return all songs on Spotify for that artist.
3) Will be able to add any song to any of your paylist(s) via button clicks as per usual.
4) Check what metadata about songs is available via the Spotify API endpoints and use that as sort/filters throughout. One metric of particular interest to me is the number of people who have played that track to sort/filter by.
5) Add checkboxes or ctrl+click, etc. ways to multiselect and add songs with one click to your Spotify playlist of choice.

## :package: Installation

Before you run the solution you need to create a Spotify API and GoogleApis Youtube Apps and provide the ClientID, ClientSecret, etc. All of these are strings that go in the Globals class properties.

Detailed instructions with screenshots will be provided for how to:
1) Create a Spotify API App in Spotify Developer Portal and get the Client ID and Client Secret. [Spotify Instructions](https://www.codeproject.com/Tips/5276627/HowTo-Setup-a-Spotify-API-App-in-the-Spotify-Devel)
2) Create a Google Apis Youtube App in the Google Apis Developer Portal and get the Client ID.
3) How to setup all this and the code in Visual Studio Community Edition 2019 (this is what I use).

## :man: Author

**Akshay Srinivasan**

- Twitter: [@AkshayS84661920](https://twitter.com/AkshayS84661920)
- Github: [@akshays2112](https://github.com/akshays2112)

## :handshake: Contributing

Contributions, issues and feature requests are welcome!

## :pencil: License

This project is licensed under [MIT](https://opensource.org/licenses/MIT) license.

## :man_astronaut: Show your support

Give a ⭐️ if this project helped you!