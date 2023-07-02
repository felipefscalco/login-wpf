using Login.Database;
using System.Windows;
using System.Windows.Input;

namespace Login
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using var db = new LoginContext();
            
            //add
            //db.Add(new User { Email = "felipefscalco@gmail.com", Password = "xdddd" });
            //db.SaveChanges();

            //search
            //var user = db.Users
            //    .OrderBy(b => b.Id)
            //    .First();

            //update
            //user.Email = "felipe@netengine.com.au";
            //db.SaveChanges();
            
            //delete
            //db.Remove(user);
            //db.SaveChanges();
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnGoogleSignIn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEmailSignIn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignUp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
