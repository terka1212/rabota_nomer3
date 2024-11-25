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
        public MainWindow()
        {
            InitializeComponent();
            BookService.ItemsSource = BookServiceEntities.GetContext().Book.ToList();
            Vis();
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
            RefreshWindow addEditWindow = new RefreshWindow((sender as Button).DataContext as Book);
            addEditWindow.ShowDialog();
            BookService.ItemsSource = BookServiceEntities.GetContext().Book.ToList();
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            addEditWindow addEditWindow = new addEditWindow();
            addEditWindow.ShowDialog();
            BookService.ItemsSource = BookServiceEntities.GetContext().Book.ToList();
            
        }

        private void BtnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }

        private void BtnDelet_Click(object sender, RoutedEventArgs e)
        {
            var servisForRemoving = BookService.SelectedItems.Cast<Book>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {servisForRemoving.Count()} элемент?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    using (var context = new BookServiceEntities())
                    {
                        foreach (var book in servisForRemoving)
                        {
                            // Загружаем объект книги из текущего контекста данных
                            var bookToDelete = context.Book.FirstOrDefault(b => b.id_book == book.id_book);
                            if (bookToDelete != null)
                            {
                                // Удаляем связанные записи (например, отзывы) перед удалением книги
                                var reviewsToDelete = context.Review.Where(r => r.id_book == bookToDelete.id_book).ToList();
                                context.Review.RemoveRange(reviewsToDelete);

                                context.Book.Remove(bookToDelete);
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        BookService.ItemsSource = context.Book.ToList();
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
            using (var context = new BookServiceEntities())
            {
                BookService.ItemsSource = context.Book
                    .Include("Author") // Включаем данные об авторах
                    .Include("Genre") // Включаем данные о жанрах
                    .ToList();
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchBox.Text;
            BookService.ItemsSource = BookServiceEntities.GetContext().Book
                .Where(r =>
                    r.id_book.ToString().Contains(searchText) ||
                    r.title.Contains(searchText) ||
                    r.Author.name_aut.Contains(searchText) ||
                    r.Genre.name_gen.Contains(searchText) ||
                    r.publisher.Contains(searchText))
                .ToList();
        }

        private void BtnMore_Click(object sender, RoutedEventArgs e)
        {

            DetailsOfBook detailsOfBook = new DetailsOfBook((sender as Button).DataContext as Book);
            detailsOfBook.ShowDialog();
        }
        private void LoadBooks()
        {
            using (var context = new BookServiceEntities())
            {
                BookService.ItemsSource = context.Book.ToList();
            }
        }

    }
}
