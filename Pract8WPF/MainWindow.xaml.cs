using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using SerDeserLib;
using ThemeLib;
using System.Windows.Markup;

namespace Pract8WPF
{

    public partial class MainWindow : Window
    {
        string blablabla;
        string path = "C:\\Users\\gruzd\\Рабочий стол\\Pract8Test.json";
        public MainWindow()
        {
            InitializeComponent();

            
        }

        
        
        private void SerButton_Click(object sender, RoutedEventArgs e)
        {
            if (Tbx.Text != string.Empty)
            {
                Class1.Serialize(Tbx.Text, path);
                App.Theme = "LightTheme";
            }
            else
            {
                MessageBox.Show("Введите текст");
            }

        }

        private void DeserButton_Click(object sender, RoutedEventArgs e)
        {
            blablabla = Class1.Deserialize<string>(path);

            DeserTbl.Text = blablabla.ToString();

            App.Theme = "DarkTheme";
        }

        private void LanBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
