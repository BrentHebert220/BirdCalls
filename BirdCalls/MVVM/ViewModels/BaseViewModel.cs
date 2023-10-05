using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdCalls.MVVM.ViewModels
{

    public partial class BaseViewModel : ObservableObject

    {
        public BaseViewModel()
        {

        }
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        //public bool IsBusy 

        //{
        //    get=>isBusy;
        //    set
        //    {
        //        if (isBusy == value)
        //            return;
        //        isBusy = value;
        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(IsNotBusy));

        //    }
        //}

        //public string Title
        //{
        //    get => title;
        //    set
        //    {
        //        if (title == value)
        //            return;
        //        title = value;
        //        OnPropertyChanged();

        //    }
        //}

        public bool IsNotBusy => !IsBusy;

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged([CallerMemberName]string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

    }

}