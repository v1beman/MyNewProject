using System;
using System.Windows;

namespace ThemeLib
{
    public class GruzdTheme
    {
        public static ResourceDictionary LoadTheme(string theme)
        {
            return new ResourceDictionary { Source = new Uri($"pack://application:,,,/ThemeLib;Component/Themes/{theme}.xaml") };
        }
    }
}
