using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenterApp.Models;
using ShoppingCenterApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenterApp.ViewModels.Movies {
    public partial class ListPageViewModel : ObservableObject {

        [ObservableProperty]
        private List<Movie> movies;

        public ListPageViewModel() {
            var service = App.Current.Handler.MauiContext.Services.GetService<MovieService>();
            Movies = service.GetAll();
        }

        [RelayCommand]
        private void OpenMovieDetailPage(Movie movie) {
            var param = new Dictionary<string, object> {
                {"movie", movie }
            };
            Shell.Current.GoToAsync("detail", param);
        }
    }
}
