using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace курсовая
{
    public static class UserSession
    {
        public static int CurrentUserId { get; set; }
    }
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        public static string authorizationRole;

        public static string GetRole(string login, string password)
        {
            var account = LiteratureServiceEntities.GetContext().Account.FirstOrDefault(a => a.login_ == login && a.password_ == password);
            if (account == null)
            {
                MessageBox.Show("Неправильный логин или пароль. Пожалуйста, попробуйте еще раз.", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
            UserSession.CurrentUserId = account.id_account; // Убедимся, что здесь правильно назначается идентификатор

            if (account != null)
                return authorizationRole = account.Role_.name_role;
            return null;
        }


        private void Button_Account(object sender, RoutedEventArgs e)
        {
            if (GetRole(textBoxLogin.Text, textBoxPassword.Password) == null)
            {
                return;
            }
            MainWindow mainWindow = new MainWindow(UserSession.CurrentUserId);
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_Out(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
