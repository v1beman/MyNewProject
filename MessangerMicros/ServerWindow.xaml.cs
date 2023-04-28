using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
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
using System.Threading;

namespace MessangerMicros
{
  
    public partial class ServerWindow : Window
    {
        DateTime now = DateTime.Now;
        MainWindow mainWindow = new MainWindow();
        private string login;
        private Socket socket;
        private List<Socket> clients = new List<Socket>();
        private CancellationTokenSource isWorking;
        public ServerWindow(string login)
        {
            this.login = login; 
            InitializeComponent();
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipPoint);
            socket.Listen(1000);
            isWorking = new CancellationTokenSource();
            ListenToClients(isWorking.Token);

        }
        private async Task ListenToClients(CancellationToken token)
        {
            while (!isWorking.IsCancellationRequested)
            {
                var client = await socket.AcceptAsync();
                clients.Add(client);
                RecieveMessage(client);
            }
        }

        private async Task RecieveMessage(Socket client)
        {
            while (true)
            {
                byte[] bytes = new byte[1024];
                await client.ReceiveAsync(bytes, SocketFlags.None);  
                string message = Encoding.UTF8.GetString(bytes);

                ChatListBox.Items.Add($"[{now.ToString("MM/dd/yyyy HH:mm:ss")}]: {message}");

                foreach (var item in clients)
                {
                    SendMessageServer(item, message);
                }
            }
        }


        public async Task SendMessageServer(Socket client, string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            await client.SendAsync(bytes, SocketFlags.None);
        }

       
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            isWorking.Cancel();
            socket.Close();
            Close();
            mainWindow.Show();
        }
        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTbx.Text == "/disconnect")
            {
                socket.Close();
                Close();
                mainWindow.Show();
            }

            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            socket.Close();
            mainWindow.Show();
        }
    }

}

