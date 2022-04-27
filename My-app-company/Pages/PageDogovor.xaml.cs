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
    /// Логика взаимодействия для PageDogovor.xaml
    /// </summary>
    public partial class PageDogovor : Page
    {
        public PageDogovor()
        {
            InitializeComponent();
            grdDogovor.ItemsSource = companyEntities.GetContext().dogovor.ToList();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();

        }
        public void UpdateData(object sender, object e)
        {
            var history = companyEntities.GetContext().dogovor.ToList();
            grdDogovor.ItemsSource = history;
            //grdDogovor.ItemsSource = companyEntities.GetContext().dogovor.Where(x => x.age.StartsWith(txtSearch.Text)).ToList();
        }
        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var remove = grdDogovor.SelectedItems.Cast<dogovor>().ToList();
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить запись?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    companyEntities.GetContext().dogovor.RemoveRange(remove);
                    companyEntities.GetContext().SaveChanges();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new AddDogovor());
        }
    }
}
