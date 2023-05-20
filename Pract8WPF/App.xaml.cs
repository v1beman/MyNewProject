using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ThemeLib;

namespace Pract8WPF
{

    public partial class App : Application
    {
        private static string theme;
        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                Current.Resources.MergedDictionaries.Add(GruzdTheme.LoadTheme(value));
            }
        }
    }
}
