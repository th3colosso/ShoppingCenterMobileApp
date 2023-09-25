using CommunityToolkit.Mvvm.ComponentModel;
using ShoppingCenterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenterApp.ViewModels.Stores {

    [QueryProperty(nameof(Establishment), "establishment")]
    public partial class DetailPageViewModel : ObservableObject{
        [ObservableProperty]
        private Establishment _establishment;
    }
}
