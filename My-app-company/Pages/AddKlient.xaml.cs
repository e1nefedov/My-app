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
    /// Логика взаимодействия для AddKlient.xaml
    /// </summary>
    public partial class AddKlient : Page
    {
        public AddKlient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                klient klient = new klient()
                {
                name = txtFIO.Text,
                adres = txtAdres.Text,
                contact = txtContact.Text,
                e_mail = txtMail.Text,

                };
                companyEntities.GetContext().klient.Add(klient);
                companyEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно добавлены!","Уведомление!",MessageBoxButton.OK,MessageBoxImage.Information);
             } catch (Exception ex)
            {
                MessageBox.Show("При добавлении данных произошла ошибка!", "Уведомление!",MessageBoxButton.OK,MessageBoxImage.Error);
            }

           
        }
    }
}
