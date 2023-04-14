using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using static System.Net.Mime.MediaTypeNames;

namespace CalendarWPF
{
    
    public partial class FoodModel : UserControl
    {
        [JsonIgnore]
        public  DependencyObject Parent
        {
            get { return base.Parent; }
        }

        private string _name;

        public string _Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private Uri wayToImage;

        public Uri WayToImage
        {
            get { return wayToImage; }
            set { wayToImage = value; }
        }

        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected= value; }
                    
            
        }
        


        public FoodModel(string _name, Uri wayToImage)
        {
           
            InitializeComponent();
            this._name = _name;
            this.wayToImage= wayToImage;
        }

     
    }
}
