using CommunityToolkit.Mvvm.ComponentModel;
using ShoppingCenterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenterApp.ViewModels.Movies {

    [QueryProperty(nameof(Movie),"movie")]
    public partial class DetailPageViewModel : ObservableObject {
        [ObservableProperty]
        private Movie _movie; 
    }
}
