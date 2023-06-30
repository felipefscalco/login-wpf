using Login.Database;
using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows;

namespace Login
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using var db = new LoginContext();
        }
    }
}
