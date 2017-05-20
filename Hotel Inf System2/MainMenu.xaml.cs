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

namespace Hotel_Inf_System2
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ReportPage1.xaml", UriKind.Relative));
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DeliveryPage2.xaml", UriKind.Relative));
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RestaurantPage3.xaml", UriKind.Relative));
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/InterestingEventsPage4.xaml", UriKind.Relative));
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TaxiPage5.xaml", UriKind.Relative));
        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DryCleaningPage6.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Authorization.xaml", UriKind.Relative));
        }
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        private void button_Click(object sender, RoutedEventArgs e)
        {

            
        }
        private void Application_NavigationFailed(object sender,
       System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            if (e.Exception is System.Net.WebException)
            {
                MessageBox.Show("Сайт " + e.Uri.ToString() + " не доступен :(");
                // Нейтрализовать ошибку, чтобы приложение продолжило свою работу
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login1.xaml", UriKind.Relative));
        }
    }
}
