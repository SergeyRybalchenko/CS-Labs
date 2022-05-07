using System;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Test.Models;
using Client = Supabase.Client;

namespace Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void ButtonOnClick(object? sender, RoutedEventArgs e)
        {
            if (DataContext is not DataBase database)
                throw new Exception();

            var message = this.FindControl<TextBox>("MessageTextBox");
            var login = this.FindControl<TextBox>("NameTextBox").Text;

            var user = database.GetUserByLogin(login);

            if (user == null)
            {
                user = new User
                {
                    Login = login,
                    DateOfCreate = DateTime.UtcNow
                };

                await database.Client.From<User>().Insert(user); 
            }

            await database.Client.From<HistoryChat>().Insert(new HistoryChat
            {
                UserId = user.Id,
                Text = message.Text,
                SendingTime = DateTime.Now
            });

            message.Text = "";
        }
    }
}