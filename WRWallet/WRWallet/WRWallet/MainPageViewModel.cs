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
        private AccountViewModel selectedAccount;
        private bool isSendLegendVisible;
        public AccountViewModel SelectedAccount
        {
            get { return selectedAccount;}

            set
            {
                selectedAccount = value;
                IsSendLegendVisible = true;
                OnPropertyChanged("selectedAccount");
            }
        }
        private string text="some text";

        public ObservableCollection<AccountViewModel> Accounts { get; set; }

        public string Text
        {

            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
                OnPropertyChanged("ISSendLegendVisible");
            }
        }

        private bool IsSendLegendVisible
        {
            get
            {
                return isSendLegendVisible;
            }
            set
            {
                isSendLegendVisible = true;
                OnPropertyChanged("IsSendLegendVisible");
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
            this.WithDrawCommand = new Command(x=> WithDraw());
            this.SendCommand = new Command(x=> Send());
            this.SelectedAccount = Accounts.First();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand WithDrawCommand { protected set; get; }

        public ICommand SendCommand { get; set; }

        private void WithDraw()
        {
            
        }

        private void Send()
        {
            
        }


    }
}
