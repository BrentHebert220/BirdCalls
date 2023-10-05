using BirdCalls.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdCalls.MVVM.ViewModels
{
    [QueryProperty("BirdSong", "BirdSong")]
public partial class BirdsDetailViewModel : BaseViewModel
{
        public BirdsDetailViewModel()
        {
            
        }
        [ObservableProperty]
    BirdSong birdSong;


    [ICommand]
    async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}
}

