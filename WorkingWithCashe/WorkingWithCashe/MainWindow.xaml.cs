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
using System.Runtime.Caching;
using Microsoft.Win32;

namespace WorkingWithCashe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetDataFromCache_Copy_Click(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\WorkingWithCashe", "dataFromCache", dataFromCache.Text);
        }

        private void GetDataFromCache_Click(object sender, RoutedEventArgs e)
        {
            string keyPath = @"HKEY_CURRENT_USER\WorkingWithCashe";
            string valueName = "dataFromCache";
            object testValue = Registry.GetValue(keyPath, valueName, null);
            if (testValue != null) { 
                dataFromCache.Text = testValue.ToString(); 
            }
            
        }

        private void OpenAnotherWindow_Click(object sender, RoutedEventArgs e)
        {
            AnotherWindows _anForm = new AnotherWindows();
            _anForm.Show();
            Close();
        }
    }
}
