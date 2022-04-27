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
    /// Логика взаимодействия для AddDogovor.xaml
    /// </summary>
    public partial class AddDogovor : Page
    {
        public AddDogovor()
        {
            InitializeComponent();
            txtKlient.SelectedValuePath = "id_klient";
            txtKlient.DisplayMemberPath = "name";
            txtKlient.ItemsSource = companyEntities.GetContext().klient.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                dogovor dogovor = new dogovor()
                {
                    id_klient = (int)txtKlient.SelectedValue,
                    data_nach = Convert.ToDateTime(txtDate.Text),
                    age = Convert.ToInt32(txtAge.Text),
                };
                companyEntities.GetContext().dogovor.Add(dogovor);
                companyEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно обновлены!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("При добавлении данных произошла ошибка!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

           
        }
    }
}
