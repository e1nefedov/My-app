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
using My_app_company.AppDataFiles;
using System.Windows.Threading;


namespace My_app_company.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageZakaz.xaml
    /// </summary>
    public partial class PageZakaz : Page
    {
        public PageZakaz()
        {
            InitializeComponent();
           
            grdZakaz.ItemsSource = companyEntities.GetContext().zakaz.ToList();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
            

        }
        public void UpdateData(object sender, object e)
        {
            var history = companyEntities.GetContext().zakaz.ToList();
            grdZakaz.ItemsSource = history;
          //  grdZakaz.ItemsSource = companyEntities.GetContext().zakaz.Where(x => x.klient.name.StartsWith(txtSearch.Text)).ToList();


        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new AddZakaz());
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var remove = grdZakaz.SelectedItems.Cast<zakaz>().ToList();
            try
            {
                if(MessageBox.Show("Вы уверены что хотите удалить запись?","Уведомление",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    companyEntities.GetContext().zakaz.RemoveRange(remove);
                    companyEntities.GetContext().SaveChanges();
                }
                

            } catch(Exception ex)
            {
                MessageBox.Show("Ошибка при удалении!","Уведомление!",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
          
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageEditZakaz((sender as Button).DataContext as zakaz));
        }

        private void SortKlient_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdSortZakaz.ItemsSource = companyEntities.GetContext().zakaz.OrderBy(x => x.id_klient).ToList();
        }

        private void SortUslugi_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdSortZakaz.ItemsSource = companyEntities.GetContext().zakaz.OrderBy(x => x.id_uslugi).ToList();
        }

       

        private void SortSotr_IsMouseCapturedChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdSortZakaz.ItemsSource = companyEntities.GetContext().zakaz.OrderBy(x => x.id_sotrudnik).ToList();
        }
    }
}
