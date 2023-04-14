using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
   
    public partial class UserPage : Page
    {
      
        public ObservableCollection<FoodModel> SelectedControls { get; set; }


        Uri relativeFastFood = new Uri("/Images/fastFood.png", UriKind.Relative);
        Uri relativeSalad = new Uri("/Images/salad.png", UriKind.Relative);
        Uri relativeSandwich = new Uri("/Images/sandwich.png", UriKind.Relative);
        public UserPage()
        {
            InitializeComponent();

            FoodModel fastFood = new FoodModel("Фаст фуд", relativeFastFood);
            fastFood.foodText.Text = fastFood._Name;
            fastFood.IsSelected= false;
            fastFood.FoodImage.Source = new BitmapImage(fastFood.WayToImage);

            FoodModel salad = new FoodModel("Салад", relativeSalad);
            salad.foodText.Text = salad._Name;
            salad.FoodImage.Source = new BitmapImage(relativeSalad);

            FoodModel sandwich = new FoodModel("Бутерброд", relativeSandwich);
            sandwich.foodText.Text = sandwich._Name;
            sandwich.FoodImage.Source = new BitmapImage(relativeSandwich);

            List<FoodModel> list = new List<FoodModel>() { fastFood, salad, sandwich };

            listbox.ItemsSource = list;

            SelectedControls = new ObservableCollection<FoodModel>();       
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).userFrame.Content = null;
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //  FoodModel selectedControl = e.AddedItems[0] as FoodModel;

            FoodModel selectedFood = listbox.SelectedItem as FoodModel;

            SelectedControls.Add(new FoodModel(selectedFood._Name, selectedFood.WayToImage) { IsSelected = selectedFood.IsSelected });

           // SelectedControls.Add(selectedControl);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveButton.IsEnabled = false;
            Converter.Ser(SelectedControls);
      
            (Application.Current.MainWindow as MainWindow).userFrame.Content = null;
          
        }
    }
}
