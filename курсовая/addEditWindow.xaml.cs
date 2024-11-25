using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для addEditWindow.xaml
    /// </summary>
    public partial class addEditWindow : Window
    {
        private Book book = new Book();
        private Author author = new Author();
        private Genre genre = new Genre();

        public addEditWindow()
        {
            InitializeComponent();
            book = new Book(); author = new Author(); genre = new Genre();
            DataContext = this; ComboStatusGenre.ItemsSource = BookServiceEntities.GetContext().Genre.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                error.AppendLine("Укажите название книги!");

            if (string.IsNullOrWhiteSpace(AuthorTextBox.Text))
                error.AppendLine("Укажите автора!");

            
            if (ComboStatusGenre.SelectedItem != null && ComboStatusGenre.SelectedItem is Genre selectedGenre) 
                genre.id_genre = selectedGenre.id_genre; 
            else error.AppendLine("Выберите жанр!");

            if (string.IsNullOrWhiteSpace(Publisher.Text))
                error.AppendLine("Укажите издателя!");

            if (string.IsNullOrWhiteSpace(Year.Text))
                error.AppendLine("Укажите год публикации!");
            else if (!int.TryParse(Year.Text, out int n))
                error.AppendLine("Неверный формат года!");
            if (string.IsNullOrWhiteSpace(Descrip.Text))
                error.AppendLine("Укажите описание!");
            if (string.IsNullOrWhiteSpace(lagug.Text))
                error.AppendLine("Укажите язык!");


            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Предупреждение!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }


            try
            {
                var context = BookServiceEntities.GetContext();

                context.Genre.Add(genre);

                author.name_aut = AuthorTextBox.Text;
                context.Author.Add(author);
                book.id_author = author.id_author;
                book.publisher = Publisher.Text;
                book.publication_year = int.Parse(Year.Text);
                book.C_language = lagug.Text;
                book.C_description = Descrip.Text;
                book.title = NameTextBox.Text;
                book.id_genre = genre.id_genre;

                context.Book.Add(book);
                context.SaveChanges();


                MessageBox.Show("Информация сохранена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }  

        private void ComboStatusAuthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AuthorTextBox.IsReadOnly = true;
        }

       
    }
}
