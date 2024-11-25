using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace курсовая
{
    public partial class DetailsOfBook : Window
    {
        
        public int Cur_Book;
        private Book book = new Book();
        
        public DetailsOfBook(Book selectedRequest)
        {
            
            int d = selectedRequest.id_book;
            Cur_Book = d;
            if (selectedRequest != null)
            {
                book = selectedRequest;
            }
            InitializeComponent();
            
            NameOfBook.Text = book.title;
            DescriptionOfBook.Text = book.C_description; 
            YearOfPublication.Text = book.publication_year.ToString();
            LanguageBook.Text = book.C_language;
        }

        private void Reviews_click(object sender, RoutedEventArgs e)
        {
            Review_ review_ = new Review_(Cur_Book);
            review_.ShowDialog();
        }
    }
}
