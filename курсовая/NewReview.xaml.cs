using System;
using System.Collections.Generic;
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
using курсовая;

namespace курсовая
{
    /// <summary>
    /// Логика взаимодействия для NewReview.xaml
    /// </summary>
    public partial class NewReview : Window
    {
        public int current_book;
        Review review = new Review();
        public NewReview(int Cur_book)
        {
            InitializeComponent();
            DataContext = review;
            current_book = Cur_book;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(ReviewTextBox.Text))
            {
                error.AppendLine("Укажите текст!");
            }

            if (string.IsNullOrEmpty(RatingComboBox.Text)) error.AppendLine("Укажите рейтинг!");
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Предупреждение!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            int selectedRating = int.Parse(RatingComboBox.Text);

            try
            {
                using (var context = new BookServiceEntities())
                {
                    // Create and add new review
                    var newReview = new Review
                    {
                        id_book = current_book,
                        review_text = ReviewTextBox.Text,
                        rating = selectedRating,
                        review_date = DateTime.Now
                    };

                    context.Review.Add(newReview);
                    context.SaveChanges();
                    this.Close();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                // Выводим все ошибки валидации
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }


    }
}
