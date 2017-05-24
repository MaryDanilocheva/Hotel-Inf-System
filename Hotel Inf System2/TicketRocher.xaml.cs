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
using System.Windows.Shapes;

namespace Hotel_Inf_System2
{
    /// <summary>
    /// Interaction logic for TicketRocher.xaml
    /// </summary>
    public partial class TicketRocher : Window
    {
        public TicketRocher()
        {
            InitializeComponent();
        }

       
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           if (comboBox.SelectedIndex == 0)
            {
                int i = 1;
            }
           else
            {
                int i = 2;
            }

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int j = int.Parse(textBox.Text);
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
          var result =   MessageBox.Show("Вы подтверждаете правильность введенной информации?", "", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.No);
            if (  result == MessageBoxResult.Yes)
            {

            }
            else if (result == MessageBoxResult.Cancel)
            {

            }
            else if ( result == MessageBoxResult.No)
            {

            }
        }

    }
}
