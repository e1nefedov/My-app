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
    /// Логика взаимодействия для AddZakaz.xaml
    /// </summary>
    public partial class AddZakaz : Page
    {
        public AddZakaz()
        {
            InitializeComponent();
            txtSotr.SelectedValuePath = "id_sotr";
            txtSotr.DisplayMemberPath = "name";
            txtSotr.ItemsSource = companyEntities.GetContext().sotrudniki.ToList();

            txtKlient.SelectedValuePath = "id_klient";
            txtKlient.DisplayMemberPath = "name";
            txtKlient.ItemsSource = companyEntities.GetContext().klient.ToList();

            txtDogovor.SelectedValuePath = "id_dogovor";
            txtDogovor.DisplayMemberPath = "id_dogovor";
            txtDogovor.ItemsSource = companyEntities.GetContext().dogovor.ToList();

            txtUsluga.SelectedValuePath = "id_uslugi";
            txtUsluga.DisplayMemberPath = "name";
            txtUsluga.ItemsSource = companyEntities.GetContext().uslugi.ToList();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                zakaz zakaz = new zakaz()
                {
                    id_sotrudnik = (int)txtSotr.SelectedValue,
                    id_klient = (int)txtKlient.SelectedValue,
                    id_uslugi = (int)txtUsluga.SelectedValue,
                    id_dogovor = (int)txtDogovor.SelectedValue,
                };
                companyEntities.GetContext().zakaz.Add(zakaz);
                companyEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно добавлены!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("При добавлении данных произошла ошибка!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

          

        }
    }
}
