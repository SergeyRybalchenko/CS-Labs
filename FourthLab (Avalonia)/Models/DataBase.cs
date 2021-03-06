using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Postgrest.Responses;
using Supabase;

namespace Test.Models
{
    public class DataBase : INotifyPropertyChanged
    {
        private const string Url = "link";
        private const string Key = "key";

        public List<User> Users { get; set; }
        public List<HistoryChat> HistoryChats { get; set; } 
        public List<GeneralChatModel> GeneralModels { get; set; } 

        public Client Client { get; }

        public DataBase()
        {
            Client.InitializeAsync(Url, Key, new SupabaseOptions()
            {
                AutoConnectRealtime = true,
                ShouldInitializeRealtime = true
            });

            Client = Client.Instance;
            LoadUserData();
            Thread.Sleep(500);
            LoadHistoryChatData();
        
            Client.From<User>().On(Client.ChannelEventType.All, (o, args) => LoadUserData());
            Client.From<HistoryChat>().On(Client.ChannelEventType.All, (o, args) => LoadHistoryChatData());
        }

        public User? GetUserByLogin(string login) 
            => Users.FirstOrDefault(x => x.Login.Equals(login));

        private async void LoadUserData()
        {
            var data = await Client.From<User>().Get();
            Users = data.Models;

            OnPropertyChanged(nameof(Users));
        }

        private async void LoadHistoryChatData()
        {
            var data = await Client.From<HistoryChat>().Get();
            HistoryChats = data.Models;

            foreach (var history in HistoryChats)
            {
                history.User = Users.FirstOrDefault(x => x.Id == history.UserId);
            }

            OnPropertyChanged(nameof(HistoryChats));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
