using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CodingDojo6.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<ItemsVM> items;
        private ObservableCollection<ItemsVM> wishlist;

        public ObservableCollection<ItemsVM> Wishlist
        {
            get { return wishlist; }
            set { wishlist = value;  RaisePropertyChanged(); }
        }

        public ObservableCollection<ItemsVM> Items
        {
            get { return items; }
            set { items = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            Items.Add(new ItemsVM("Lego", "-", new BitmapImage(new Uri("Images/lego.jpg", UriKind.Relative))));
            Items.Add(new ItemsVM("Playmobil", "-", new BitmapImage(new Uri("Images/playmobil.jpg", UriKind.Relative))));
        }
    }
}