using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для RefreshWindow.xaml
    /// </summary>
    public partial class RefreshWindow : Window
    {
       
        private Source_ book = new Source_();

        public RefreshWindow(Source_ selectedRequest)
        {
            
            InitializeComponent();
           
            if (selectedRequest != null)
            {
                book = selectedRequest;
            }
            DataContext = book;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrWhiteSpace(Publisher.Text))
            error.AppendLine("Укажите издателя!");

            if (string.IsNullOrWhiteSpace(year_publish.Text))
                error.AppendLine("Укажите год публикации!");
            else if (!int.TryParse(year_publish.Text, out int n))
                error.AppendLine("Неверный формат года!");

            if (string.IsNullOrWhiteSpace(language.Text))
                error.AppendLine("Укажите язык!");

            if (string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
                error.AppendLine("Укажите описание!");

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Предупреждение!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                using (var context = new LiteratureServiceEntities()) {
                    book.C_description = DescriptionTextBox.Text;
                    book.C_language = language.Text;
                    book.publisher = Publisher.Text;
                    book.publication_year = int.Parse(year_publish.Text); 
                    context.Source_.AddOrUpdate(book); 
                    context.SaveChanges(); 
                }
                MessageBox.Show("Информация сохранена"); 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
