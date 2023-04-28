using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MessangerMicros
{
   
    public partial class MainWindow : Window
    {
             
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateChatBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTbx.Text == null || LoginTbx.Text == string.Empty)
            {
                MessageBox.Show("Заполните имя пользователя!");
            }
            else
            {
                ServerWindow serverWindow = new ServerWindow(LoginTbx.Text);
                serverWindow.Show();
                Close();
            }
        }

        private void EnterChatBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(IpTbx.Text, "^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$") && LoginTbx.Text != null && LoginTbx.Text != string.Empty)
            {
                ClientWindow clientWindow = new ClientWindow(IpTbx.Text, LoginTbx.Text);
                clientWindow.Show();
                Close();

            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
