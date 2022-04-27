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
    /// Логика взаимодействия для PageEditZakaz.xaml
    /// </summary>
    public partial class PageEditZakaz : Page
    {
        public PageEditZakaz(zakaz zakaz)
        {
            InitializeComponent();
            txtKlient.SelectedIndex = (int)zakaz.id_klient - 1;
            txtKlient.SelectedValuePath = "id_klient";
            txtKlient.DisplayMemberPath = "name";
            txtKlient.ItemsSource = companyEntities.GetContext().klient.ToList();

            txtSotr.SelectedIndex = (int)zakaz.id_sotrudnik - 1;
            txtSotr.SelectedValuePath = "id_sotr";
            txtSotr.DisplayMemberPath = "name";
            txtSotr.ItemsSource = companyEntities.GetContext().sotrudniki.ToList();

            txtUsluga.SelectedIndex = (int)zakaz.id_uslugi - 1;
            txtUsluga.SelectedValuePath = "id_uslugi";
            txtUsluga.DisplayMemberPath = "name";
            txtUsluga.ItemsSource = companyEntities.GetContext().uslugi.ToList();


            ZakazObj.id_zakaz = zakaz.id_zakaz;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IEnumerable<zakaz> zakaz = companyEntities.GetContext().zakaz.Where(x => x.id_zakaz == ZakazObj.id_zakaz).AsEnumerable().Select(x => {
                 
                    x.id_klient = (int)txtKlient.SelectedValue;
                    
                    x.id_sotrudnik = (int)txtSotr.SelectedValue;
                    x.id_uslugi = (int)txtUsluga.SelectedValue;

                    return x;
                });
                foreach (zakaz zkz in zakaz)
                {
                    companyEntities.GetContext().Entry(zkz).State = System.Data.Entity.EntityState.Modified;
                }
                companyEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные упешно обновлены!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
