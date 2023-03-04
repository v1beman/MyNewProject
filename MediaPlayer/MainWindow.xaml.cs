using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using static System.Net.WebRequestMethods;

namespace MediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum Status
        {
            StartPl, PausePl
        }
        Status currentStatus;

        private int _pos;

        private bool _isRepeated = false;
        public MainWindow()
        {
            
            InitializeComponent();
            
            Thread thread = new Thread(_  =>
            {
               
                while (true)
                {
                    
                    this.Dispatcher.Invoke(() => { DurationSlider.Value = MediaEl.Position.Ticks; });

                    this.Dispatcher.Invoke(() => { CurrentTimer.Content = MediaEl.Position.ToString(@"mm\:ss"); });
                    this.Dispatcher.Invoke(() => {
                       if (MediaEl.NaturalDuration.HasTimeSpan)
                       {
                            var a = MediaEl.NaturalDuration.TimeSpan - MediaEl.Position;
                            RemainTimer.Content = a.ToString(@"mm\:ss");
                       } 
                    });
                    
                    Thread.Sleep(1000);
                }
            });
            thread.Start();
        }

        private void FileChoice_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new() { IsFolderPicker = true };
            var result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                string[] files = Directory.GetFiles(dialog.FileName, "*.mp3");
                foreach( string file in files )
                {
                  Music.Items.Add(file);
                  
                }
            }
            Music.SelectedIndex = 0;
            currentStatus = Status.StartPl;
            PlaySong(_pos);
        }

        private void PlaySong(int pos)
        {
            if (pos >= Music.Items.Count || pos < 0)
            {
                Music.SelectedIndex = 0;
            }
            else
            {
                var uri = new Uri((string)Music.Items[pos]);
                MediaEl.Source = uri;

                MediaEl.Play();
            }                      
        }

        private void MediaEl_MediaOpened(object sender, RoutedEventArgs e)
        {
            DurationSlider.Value = 0;
            DurationSlider.Maximum = MediaEl.NaturalDuration.TimeSpan.Ticks;

            
            
        }

        private void DurationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaEl.Position = new TimeSpan(Convert.ToInt64(DurationSlider.Value));
            
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if(currentStatus == Status.StartPl)
            {
                MediaEl.Pause();
                currentStatus = Status.PausePl;
            }
            else
            {
                MediaEl.Play();
                currentStatus = Status.StartPl;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {

            _pos += 1;
            Music.SelectedIndex = _pos;

            PlaySong(_pos);
        }

        private void Music_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _pos = Music.SelectedIndex;
            PlaySong(_pos);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            _pos -= 1;
            Music.SelectedIndex = _pos;
            PlaySong(_pos);
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaEl.Volume = (double)VolumeSlider.Value;
        }

        private void MediaEl_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (_isRepeated == false)
            {
                Music.SelectedIndex++;
               
            }
            else if(_isRepeated == true) 
            {
                PlaySong(_pos);
            }

            if((_pos) + 1 >= Music.Items.Count) 
            {
                Music.SelectedIndex = 0;
            }
            
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (_isRepeated == false)
            {
                _isRepeated = true;
                RepeatButton.Background = Brushes.Gray;
            }
            else if (_isRepeated == true)
            {
                _isRepeated = false;
                RepeatButton.Background = Brushes.White;
            }          
        }

        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {                 
            string[] random = randomMassive();
            Music.Items.Clear();

            foreach (string file in random)
            {
                Music.Items.Add(file);

            }
        }

        private string[] randomMassive()
        {
            string[] randomList = (from object item in Music.Items select item.ToString()).ToArray<string>();

            Random rand = new Random();
            for (int i = randomList.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i);
                string tmp = randomList[i];
                randomList[i] = randomList[j];
                randomList[j] = tmp;
            }            
            return randomList;
        }
    }
}
