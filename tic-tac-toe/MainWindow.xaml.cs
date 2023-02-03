using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        List<Button> buttons;
        
        public MainWindow()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 700;
           
        }



        private void Click(object sender, RoutedEventArgs e)
        {           
            var button = (Button)sender;

            button.Content = currentPlayer.ToString();
            button.IsEnabled = false;
            buttons.Remove(button);
            CheckWin();
            PC_Step();

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
           
            buttons = new List<Button> { First, Second, Third, Fourth, Fifth, Sixth, Seventh, Eigth, Ninth };

            foreach (Button x in buttons)
            {
                x.IsEnabled = true;
                x.Content = "";

            }
            if( currentPlayer == Player.O)
            {
                PC_Step();
            }
            
            
                                      

        }
        private void PC_Step()
        {
            if (buttons.Count > 0)
            {
                int ind = random.Next(buttons.Count);
                buttons[ind].IsEnabled = false;
                buttons[ind].Content = currentPlayer == Player.X ? Player.O.ToString() : Player.X.ToString();
                buttons.RemoveAt(ind);
                CheckWin();

            }

        }

        private void CheckWin()
        {
            if ((First.Content.ToString() == "X" && Second.Content.ToString() == "X" && Third.Content.ToString() == "X")
            || (Fourth.Content.ToString() == "X" && Fifth.Content.ToString() == "X" && Sixth.Content.ToString() == "X")
            || (Seventh.Content.ToString() == "X" && Ninth.Content.ToString() == "X" && Eigth.Content.ToString() == "X")
            || (First.Content.ToString() == "X" && Fourth.Content.ToString() == "X" && Seventh.Content.ToString() == "X")
            || (Second.Content.ToString() == "X" && Fifth.Content.ToString() == "X" && Eigth.Content.ToString() == "X")
            || (Third.Content.ToString() == "X" && Sixth.Content.ToString() == "X" && Ninth.Content.ToString() == "X")
            || (First.Content.ToString() == "X" && Fifth.Content.ToString() == "X" && Ninth.Content.ToString() == "X")
            || (Third.Content.ToString() == "X" && Fifth.Content.ToString() == "X" && Seventh.Content.ToString() == "X"))

            {

                foreach (Button x in buttons)
                {
                    x.IsEnabled = false;
                    x.Content = "";

                }
                MessageBox.Show("Победили Х!");
                currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;

            }

            else if ((First.Content.ToString() == "O" && Second.Content.ToString() == "O" && Third.Content.ToString() == "O")
            || (Fourth.Content.ToString() == "O" && Fifth.Content.ToString() == "O" && Sixth.Content.ToString() == "O")
            || (Seventh.Content.ToString() == "O" && Ninth.Content.ToString() == "O" && Eigth.Content.ToString() == "O")
            || (First.Content.ToString() == "O" && Fourth.Content.ToString() == "O" && Seventh.Content.ToString() == "O")
            || (Second.Content.ToString() == "O" && Fifth.Content.ToString() == "O" && Eigth.Content.ToString() == "O")
            || (Third.Content.ToString() == "O" && Sixth.Content.ToString() == "O" && Ninth.Content.ToString() == "O")
            || (First.Content.ToString() == "O" && Fifth.Content.ToString() == "O" && Ninth.Content.ToString() == "O")
            || (Third.Content.ToString() == "O" && Fifth.Content.ToString() == "O" && Seventh.Content.ToString() == "O"))
            {
                
                foreach (Button x in buttons)
                {
                    x.IsEnabled = false;
                    x.Content = "";

                }
                MessageBox.Show("Победили 0");
                currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
                
            }
            
            else if (buttons.Count == 0)
            {              
                foreach (Button x in buttons)
                {
                    x.IsEnabled = false;
                    x.Content = "";

                }
                MessageBox.Show("Ничья!");
                currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;

            }

        }


    }
}
