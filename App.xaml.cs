using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CalendarPract6
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string theme;
        public static string Theme
        {
            get { return theme; }
            set
            { 
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/ThemeLib;component/Themes/{value}.xaml",UriKind.Absolute) };
                Current.Resources.MergedDictionaries.RemoveAt(2);
                Current.Resources.MergedDictionaries.Insert(2, dict);
            }
        }
        public App()
        {
            InitializeComponent();
        }
    }
}
