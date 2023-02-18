using MahApps.Metro.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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



namespace Pract_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private ObservableCollection<Model> toDoList = new ObservableCollection<Model>(); 
        private Converter converter;
        private readonly string Path = "C:\\Users\\gruzd\\Рабочий стол\\Notes.json";

        public MainWindow()
        {
            InitializeComponent();
            dgToDo.SelectionChanged += DgToDo_SelectionChanged;
            
        }

        private void DgToDo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            date_pick.SelectedDate = ((Model)dgToDo.SelectedItem).CreationDate;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            date_pick.Text = DateTime.Now.ToString();

            converter = new Converter(Path);

            toDoList = converter.Deser();

            dgToDo.ItemsSource = toDoList;

            dgToDo.IsReadOnly = true;

          
        }





        private void create_but_Click(object sender, RoutedEventArgs e)
        {

            toDoList.Add(new Model() { Name = name_box.Text, Description = des_box.Text, CreationDate = (DateTime)date_pick.SelectedDate });


            Converter.Ser(toDoList);

        }

        private void del_but_Click(object sender, RoutedEventArgs e)
        {
            
           toDoList.RemoveAt(dgToDo.SelectedIndex);

            Converter.Ser(toDoList);
           
        }

        private void save_but_Click(object sender, RoutedEventArgs e)
        {
            var item = toDoList[dgToDo.SelectedIndex];

            item.Name = name_box.Text; 
            item.Description = des_box.Text;

            toDoList[dgToDo.SelectedIndex] = item;
            
            Converter.Ser(toDoList);

        }
    }
}
