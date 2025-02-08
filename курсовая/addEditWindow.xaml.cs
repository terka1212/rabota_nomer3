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
        private Source_ source = new Source_();
        private Author author = new Author();
        private Topic topic = new Topic();

        public addEditWindow()
        {
            InitializeComponent();
            source = new Source_(); author = new Author(); topic = new Topic();
            DataContext = this; 
            ComboStatusTopic.ItemsSource = LiteratureServiceEntities.GetContext().Topic.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                error.AppendLine("Укажите название книги!");

            if (string.IsNullOrWhiteSpace(AuthorTextBox.Text))
                error.AppendLine("Укажите автора!");

            
            if (ComboStatusTopic.SelectedItem != null && ComboStatusTopic.SelectedItem is Topic selectedtopic) 
                topic.id_topic = selectedtopic.id_topic; 
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

            if (string.IsNullOrWhiteSpace(ISBNTextBox.Text))
                error.AppendLine("Укажите ISBN!");

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Предупреждение!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }


            try
            {
                var context = LiteratureServiceEntities.GetContext();

                context.Topic.Add(topic);

                author.name_aut = AuthorTextBox.Text;
                context.Author.Add(author);
                source.id_author = author.id_author;
                source.publisher = Publisher.Text;
                source.publication_year = int.Parse(Year.Text);
                source.C_language = lagug.Text;
                source.C_description = Descrip.Text;
                source.title = NameTextBox.Text;
                source.id_topic = topic.id_topic;
                source.isbn = ISBNTextBox.Text;

                context.Source_.Add(source);
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
