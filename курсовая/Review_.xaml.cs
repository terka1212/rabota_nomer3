using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
    /// <summary>
    /// Логика взаимодействия для Review.xaml
    /// </summary>
    public partial class Review_ : Window
    {
        public int Cur_Book;
        private Source_ book = new Source_();
        public Review_(int selectedRequest)
        {
            
            Cur_Book = selectedRequest;
            
            InitializeComponent();
            Vis();
            UpdateReviewData(Cur_Book); // Обновляем отзывы для текущей книги
        }

        private void BookService_Loaded(object sender, RoutedEventArgs e)
        {
            if (BookReview.Columns.Any())
            {
                BookReview.Columns.RemoveAt(BookReview.Columns.Count - 1);
            }
        }

        private void AddReviewButton_Click(object sender, RoutedEventArgs e)
        {
            NewReview newReview = new NewReview(Cur_Book);
            newReview.ShowDialog();

            UpdateReviewData(Cur_Book);
        }

        private void UpdateReviewData(int bookId)
        {
            using (var context = new LiteratureServiceEntities())
            {
                BookReview.ItemsSource = context.Review.Where(review => review.id_source == bookId).ToList();
            }
        }
        private void Vis()
        {
            switch (AuthorizationWindow.authorizationRole)
            {
                case "Администратор":
                    break;
                //case "Менеджер":
                //    BookReview.Loaded += BookService_Loaded;
                //    break;
                case "Пользователь":
                    BookReview.Loaded += BookService_Loaded;
                    break;
                default:
                    return;
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var servisForRemoving = BookReview.SelectedItems.Cast<Review>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие " +
                $"{servisForRemoving.Count()} элемент?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    using (var context = new LiteratureServiceEntities())
                    {
                        foreach (var review in servisForRemoving)
                        {
                            var reviewToDelete = context.Review.Find(review.id_review); if (reviewToDelete != null)
                            {
                                context.Review.Attach(reviewToDelete); // Присоединяем объект к контексту, если он не отслеживается
                                context.Review.Remove(reviewToDelete);
                            }
                        }
                        context.SaveChanges(); MessageBox.Show("Данные удалены!"); // Обновляем данные после удаления отзыва для текущей книги
                        UpdateReviewData(Cur_Book);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
