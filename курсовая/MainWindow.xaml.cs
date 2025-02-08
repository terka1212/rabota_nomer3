using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace курсовая
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public int currentAccountId;

        public MainWindow(int current_id)
        {
            InitializeComponent();

            currentAccountId = current_id;

            BookService.ItemsSource = LiteratureServiceEntities.GetContext().Source_.ToList();
            Vis();

            LoadUserData();

            using (var context = new LiteratureServiceEntities())
            {
                CategoryComboBox.ItemsSource = context.Category.ToList();
            }
        }

        private void LoadUserData()
        {
            using (var context = new LiteratureServiceEntities())
            {
                var user = context.User_
                    .Where(u => u.id_account == currentAccountId)
                    .Select(u => new { u.first_name, u.last_name })
                    .FirstOrDefault();

                if (user != null)
                {
                    UserNameTextBlock.Text = $"{user.first_name} {user.last_name}";
                }
                else
                {
                    UserNameTextBlock.Text = "Пользователь не найден";
                    MessageBox.Show($"Пользователь с id_account = {currentAccountId} не найден");
                }
            }
        }

        private void BookService_Loaded(object sender, RoutedEventArgs e)
        {
            if (BookService.Columns.Any())
            {
                BookService.Columns.RemoveAt(BookService.Columns.Count - 1);
            }
        }

        private void Vis()
        {
            switch (AuthorizationWindow.authorizationRole)
            {
                case "Админ":
                    break;
                case "Менеджер":
                    BtnDelet.Visibility = Visibility.Collapsed;
                    BtnAdd.Visibility = Visibility.Collapsed;

                    break;
                case "Читатель":
                    BtnAdd.Visibility = Visibility.Collapsed;
                    BtnDelet.Visibility = Visibility.Collapsed;
                    BookService.Loaded += BookService_Loaded;
                    break;
                default:
                    return;
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            RefreshWindow addEditWindow = new RefreshWindow((sender as Button).DataContext as Source_);
            addEditWindow.ShowDialog();
            BookService.ItemsSource = LiteratureServiceEntities.GetContext().Source_.ToList();

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            addEditWindow addEditWindow = new addEditWindow();
            addEditWindow.ShowDialog();
            BookService.ItemsSource = LiteratureServiceEntities.GetContext().Source_.ToList();

        }

        private void BtnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }

        private void BtnDelet_Click(object sender, RoutedEventArgs e)
        {
            var servisForRemoving = BookService.SelectedItems.Cast<Source_>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {servisForRemoving.Count()} элемент?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    using (var context = new LiteratureServiceEntities())
                    {
                        foreach (var source in servisForRemoving)
                        {
                            // Загружаем объект книги из текущего контекста данных
                            var bookToDelete = context.Source_.FirstOrDefault(b => b.id_source == source.id_source);
                            if (bookToDelete != null)
                            {
                                // Удаляем связанные записи (например, отзывы) перед удалением книги
                                var reviewsToDelete = context.Review.Where(r => r.id_source == bookToDelete.id_source).ToList();
                                context.Review.RemoveRange(reviewsToDelete);

                                context.Source_.Remove(bookToDelete);
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        BookService.ItemsSource = context.Source_.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                }
            }
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new LiteratureServiceEntities())
            {
                BookService.ItemsSource = context.Source_
                    .Include("Author") // Включаем данные об авторах
                    .Include("Topic") // Включаем данные о жанрах
                    .ToList();
            }

            CategoryComboBox.SelectedIndex = -1;        
        }
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchBox.Text;
            BookService.ItemsSource = LiteratureServiceEntities.GetContext().Source_
                .Where(r =>
                    r.id_source.ToString().Contains(searchText) ||
                    r.title.Contains(searchText) ||
                    r.Author.name_aut.Contains(searchText) ||
                    r.Topic.name_topic.Contains(searchText) ||
                    r.publisher.Contains(searchText))
                .ToList();
        }

        private void BtnMore_Click(object sender, RoutedEventArgs e)
        {
            DetailsOfBook detailsOfBook = new DetailsOfBook((sender as Button).DataContext as Source_);
            detailsOfBook.ShowDialog();
        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCategory = CategoryComboBox.SelectedItem as Category;
            if (CategoryComboBox.SelectedIndex == -1)  
                return; 
            using (var context = new LiteratureServiceEntities())
            {
                var filteredBooks = context.Source_
                    .Include("Author")
                    .Include("Topic")
                    .Where(book => book.Category.Any(cat => cat.id_category == selectedCategory.id_category))
                    .ToList();
                BookService.ItemsSource = filteredBooks;
            }
            
        }
    }
}