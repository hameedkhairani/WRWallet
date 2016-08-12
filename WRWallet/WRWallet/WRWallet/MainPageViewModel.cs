using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace WRWallet
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public AccountViewModel SelectedAccount { get; set; }
        private string text="some text";

        public ObservableCollection<AccountViewModel> Accounts { get; set; }

        public string Text
        {

            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }
        public MainPageViewModel()
        {
            Accounts = new ObservableCollection<AccountViewModel>
            {
                new AccountViewModel {Currency = "$", Amount = 1200},
                new AccountViewModel {Currency = "£", Amount = 2600},
                new AccountViewModel {Currency = "‎€", Amount = 4000}
            };
            this.AddCharCommand = new Command(x=> Text="test");
            this.SelectedAccount = Accounts.First();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand AddCharCommand { protected set; get; }
    }
}
