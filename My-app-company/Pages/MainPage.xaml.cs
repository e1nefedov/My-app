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


namespace My_app_company.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnZakaz_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageZakaz());
        }

        private void btnDogovor_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageDogovor());
        }

        private void btnKlient_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageKlient());
        }

        private void btnUslugi_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageUslugi());
        }

        private void btnSotr_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageSotr());
        }
    }
}
