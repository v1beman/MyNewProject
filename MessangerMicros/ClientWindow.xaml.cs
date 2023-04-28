using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace MessangerMicros
{
    public partial class ClientWindow : Window
    {
        DateTime now = DateTime.Now;
        private Socket server;
        private string login;
        MainWindow mainWindow = new MainWindow();
        public ClientWindow(string ip, string login)
        {
            InitializeComponent();
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.ConnectAsync(ip, 8888);
            this.login = login;
            RecieveMessage();
        }
        private async Task RecieveMessage()
        {
            while (true)
            {
                byte[] bytes = new byte[1024];
                await server.ReceiveAsync(bytes, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);
                ChatListBox.Items.Add($"[{now.ToString("MM/dd/yyyy HH:mm:ss")}]: {message}");
            }
        }

  

     
        public async Task SendMessageClient(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            await server.SendAsync(bytes, SocketFlags.None);
        }

        private async void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MessageTbx.Text == "/disconnect")
            {
                server.Close();
                Close();
                mainWindow.Show();
            }
            SendMessageClient(MessageTbx.Text);      
            
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            server.Close();
            Close();       
            mainWindow.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            server.Close();
            mainWindow.Show();
        }
    }
}
