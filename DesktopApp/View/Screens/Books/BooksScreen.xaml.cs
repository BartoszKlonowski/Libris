﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopApp.View.Screens
{
    /// <summary>
    /// Interaction logic for BooksScreen.xaml
    /// </summary>
    public partial class BooksScreen : UserControl
    {
        public BooksScreen()
        {
            InitializeComponent();
<<<<<<< HEAD
            DAL.DatabaseContext dbContext = new DAL.DatabaseContext();
            FilteredListView.ItemsSource = dbContext.Books.ToList();
=======
>>>>>>> e41ba64... Move BooksScreen to Books subdirectory
        }
    }
}
