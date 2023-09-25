using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenterApp.Models;
using ShoppingCenterApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenterApp.ViewModels.Stores {
    internal partial class ListPageViewModel : ObservableObject {

        [ObservableProperty]
        private string _textSearch;
        [ObservableProperty]
        private List<Establishment> _establishmentFilteredList;

        private List<Establishment> _establishmentFullList;

        public ListPageViewModel() {
            var storeService = App.Current.Handler.MauiContext.Services.GetService<StoreService>();
            _establishmentFullList = storeService.GetAll();
            _establishmentFilteredList = _establishmentFullList.ToList();
        }

        [RelayCommand]
        private void StoreSearchTextChanged() {
            EstablishmentFilteredList = _establishmentFullList.Where(x => x.Name.ToLower().Contains(TextSearch.ToLower())).ToList();
        }

    }
}
