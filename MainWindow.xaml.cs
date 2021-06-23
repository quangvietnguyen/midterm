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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Logins
        {
            public int id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public int superUser { get; set; }
        }

        Dictionary<string, Logins> login = new Dictionary<string, Logins>();
        Homepage p = new Homepage();
        public MainWindow()
        {
            InitializeComponent();
            login.Add("viet", new Logins { id = 1, username = "viet", password = "student", superUser = 1 });
            login.Add("professor", new Logins { id = 2, username = "professor", password = "prof", superUser = 1 });
            login.Add("user1", new Logins { id = 3, username = "user1", password = "student1", superUser = 0 });
            login.Add("user2", new Logins { id = 4, username = "user2", password = "student2", superUser = 0 });
            login.Add("user3", new Logins { id = 5, username = "user3", password = "student3", superUser = 0 });
        }

       
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (login[tbUser.Text].password == tbPass.Password)
            {
                p.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Login", "Login Failed, Please try again!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            if (login[tbUser.Text].superUser == 1)
            {
                MessageBox.Show("Allowed", "You can change the Login Data!", MessageBoxButton.OK, MessageBoxImage.Information);
            } else if (login[tbUser.Text].superUser == 0)
            {
                MessageBox.Show("Not Allowed", "You can not change the Login Data!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
