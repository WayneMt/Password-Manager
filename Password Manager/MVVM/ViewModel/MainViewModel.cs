using Password_Manager.Core;
using System;

namespace Password_Manager.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand MyVaultViewCommand { get; set; }
        public RelayCommand FavouritesViewCommand { get; set; }
        public RelayCommand PaymentsViewCommand { get; set; }
        public RelayCommand PasswordGeneratorViewCommand { get; set; }

        public MyVaultViewModel MyVaultVM { get; set; }
        public FavouritesViewModel FavouritesVM { get; set; }
        public PaymentsViewModel PaymentsVM { get; set; }
        public PasswordGeneratorViewModel PasswordGeneratorVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        { 
            MyVaultVM = new MyVaultViewModel();
            FavouritesVM = new FavouritesViewModel();
            PaymentsVM = new PaymentsViewModel();
            PasswordGeneratorVM = new PasswordGeneratorViewModel();
            CurrentView = MyVaultVM;

            MyVaultViewCommand = new RelayCommand(o =>
            {
                CurrentView = MyVaultVM;
            });

            FavouritesViewCommand = new RelayCommand(o =>
            {
                CurrentView = FavouritesVM;
            });

            PaymentsViewCommand = new RelayCommand(o =>
            {
                CurrentView = PaymentsVM;
            });

            PasswordGeneratorViewCommand = new RelayCommand(o =>
            {
                CurrentView = PasswordGeneratorVM;
            });
        }
    }
}
