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

namespace My_app_company.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddSotr.xaml
    /// </summary>
    public partial class PageAddSotr : Page
    {
        public PageAddSotr()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                sotrudniki sotrudniki = new sotrudniki()
                {
                    name = txtFIO.Text,
                    dolzh = txtDolzh.Text,
                    adres = txtAdres.Text,
                    contact = txtContact.Text,
                };
                companyEntities.GetContext().sotrudniki.Add(sotrudniki);
                companyEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно обновлены!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("При добавлении данных произошла ошибка!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
