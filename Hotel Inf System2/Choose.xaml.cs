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
    /// Interaction logic for Choose.xaml
    /// </summary>
    public partial class Choose : Page
    {
        User user;
        public Choose(User id)
        {
            user = id;
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {try
            {
                NavigationService.Navigate(new ReportPage1(user));
            }catch { }
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

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
