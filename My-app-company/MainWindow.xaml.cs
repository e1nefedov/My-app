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
using My_app_company.Pages; 

namespace My_app_company
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameObj.MainFrame = frameMain;
           frameMain.Navigate(new MainPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frameMain.GoBack();
            } catch (Exception ex)
            {
                if(MessageBox.Show("Закрыть приложение?", "Уведомление!",MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    this.Close();  
                }
            }
        }
    }
}
