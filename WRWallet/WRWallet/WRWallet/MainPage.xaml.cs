using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WRWallet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var vm = new MainPageViewModel();
            BindingContext = vm;
            BindingContext = new MainPageViewModel();
            AccountsListView.ItemsSource = vm.Accounts;
        }
    }
}
