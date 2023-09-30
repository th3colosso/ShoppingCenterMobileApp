using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenterApp.ViewModels.Restaurants {

    [QueryProperty(nameof(Establishment), "establishment")]
    public partial class DetailPageViewModel : ObservableObject {
        [ObservableProperty]
        private Establishment _establishment;

        [RelayCommand]
        private void GoBackClicked() => Shell.Current.GoToAsync("..");
    }
}
