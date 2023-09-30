using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenterApp.Models;
using ShoppingCenterApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenterApp.ViewModels.Restaurants {
    partial class ListPageViewModel : ObservableObject {

        [ObservableProperty]
        private string _textSearch;

        [ObservableProperty]
        private List<Establishment> _establishmentFilteredList;

        private List<Establishment> _establishmentFullList;

        public ListPageViewModel() {
            var restaurantService = App.Current.Handler.MauiContext.Services.GetService<RestaurantService>();
            _establishmentFullList = restaurantService.GetAll();
            _establishmentFilteredList = _establishmentFullList.ToList();
        }

        [RelayCommand]
        public void ResturantSearchTextChanged() {
            EstablishmentFilteredList = _establishmentFullList.Where(x => x.Name.ToLower().Contains(TextSearch.ToLower())).ToList();
        }

        [RelayCommand]
        public async void EstablishmentTapped(Establishment establishment) {
            
            var navigationParams = new Dictionary<string, object>() {
                {"establishment", establishment }
            };

            await Shell.Current.GoToAsync("detail", navigationParams);
        }

    }
}
