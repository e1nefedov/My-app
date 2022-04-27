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
    /// Логика взаимодействия для PageSotr.xaml
    /// </summary>
    public partial class PageSotr : Page
    {
        public PageSotr()
        {
            InitializeComponent();
            grdSotr.ItemsSource = companyEntities.GetContext().sotrudniki.ToList();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
        }
        public void UpdateData(object sender, object e)
        {
            var history = companyEntities.GetContext().sotrudniki.ToList();
            grdSotr.ItemsSource = history;
            grdSotr.ItemsSource = companyEntities.GetContext().sotrudniki.Where(x => x.name.StartsWith(txtSearch.Text) || x.dolzh.StartsWith(txtSearch.Text) || x.adres.StartsWith(txtSearch.Text) || x.contact.StartsWith(txtSearch.Text)).ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageAddSotr());
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var remove = grdSotr.SelectedItems.Cast<sotrudniki>().ToList();
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить запись?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    companyEntities.GetContext().sotrudniki.RemoveRange(remove);
                    companyEntities.GetContext().SaveChanges();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
