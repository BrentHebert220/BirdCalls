using BirdCalls.MVVM.Models;
using BirdCalls.MVVM.Views;
using BirdCalls.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdCalls.MVVM.ViewModels
{
    public partial class BirdsViewModel : BaseViewModel

    {
        BirdService birdService;
        public ObservableCollection<BirdSong> BirdSongs { get; } = new();



        public BirdsViewModel(BirdService birdService)
        {
            Title = "Bird Songd";
            this.birdService = birdService;


        }

        [ICommand]
        async Task GoToDetailsAsync(BirdSong birdSong)
        {
            if (birdSong is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(BirdsDetailPage)}", true,
                new Dictionary<string, object>
                {
                    {"BirdSong", birdSong}

                });
        }

        [ICommand]
        async Task GetBirdSongsAsync()
        {
            if (IsBusy)
                return;


            try
            {
                IsBusy = true;
                var birdSongs = await birdService.GetBirdSongs();

                if (BirdSongs.Count != 0)
                    BirdSongs.Clear();

                foreach (var birdSong in birdSongs)
                    BirdSongs.Add(birdSong);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!", $"Unable to get birdSong: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}