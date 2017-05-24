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
using System.IO;

namespace Hotel_Inf_System2
{
    /// <summary>
    /// Interaction logic for ReportPage1.xaml
    /// </summary>
    public partial class ReportPage1 : Page
    {
        User user;
        public ReportPage1(User h)
        {
            user = h;
            InitializeComponent();

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SwissChocolateTrain.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Chateau.xaml", UriKind.Relative));
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Rochers(user));

        }

        
    }
}
