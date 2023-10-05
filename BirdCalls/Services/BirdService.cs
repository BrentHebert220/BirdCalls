using BirdCalls.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BirdCalls.Services
{
    public class BirdService
    {
        HttpClient httpClient;

        public BirdService()
        {
            httpClient = new HttpClient();
        }
        List<BirdSong> birdSongList = new();
        public async Task<List<BirdSong>> GetBirdSongs()
        {
            if (birdSongList?.Count > 0)
                return birdSongList;

            //-------Online------ 

            //var response = await httpClient.GetAsync("https://raw.githubusercontent.com/BrentHebert220/BrentHebert/main/presidents.json");
            //if (response.IsSuccessStatusCode)
            //{
            //    birdSongList = await response.Content.ReadFromJsonAsync(BirdSongContext.Default.ListBirdSong);
            //}

            //return birdSongList;



            //-------Offline------
            using var stream = await FileSystem.OpenAppPackageFileAsync("birds.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            birdSongList = JsonSerializer.Deserialize(contents, BirdSongContext.Default.ListBirdSong);

            return birdSongList;
        }
    }
}
