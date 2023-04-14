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

namespace CalendarWPF
{
   
    public partial class MainWindow : Window
    {
        private DateTime _date;
        public MainWindow()
        {
            InitializeComponent();

            Month.Text = _date.ToString();

            _date = DateTime.Now;

            Month.Text = _date.ToString("MMMM yyyy");

            monthSwap(DateTime.DaysInMonth(_date.Year, _date.Month));
        }

        private void monthSwap(int mounthCount)
        {
         

            for (int i = 0; i <= mounthCount; i++)
            {
                DayView day = new DayView();
                day.dayNumber.Text = i.ToString();
                monthWrapPanel.Children.Add(day);
            }
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            _date = _date.AddMonths(1);

            Month.Text = _date.ToString("MMMM yyyy");

            monthWrapPanel.Children.Clear();
            monthSwap(DateTime.DaysInMonth(_date.Year, _date.Month));
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            _date = _date.AddMonths(-1);

            Month.Text = _date.ToString("MMMM yyyy");

            monthWrapPanel.Children.Clear();
            monthSwap(DateTime.DaysInMonth(_date.Year, _date.Month));
        }
    }
}
