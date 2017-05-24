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
    /// Логика взаимодействия для TicketChateau.xaml
    /// </summary>
    public partial class TicketChateau : Page
    {
        User user;
        
        public TicketChateau(User g )
        {
            user = g;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = new List<User>();
            var result = MessageBox.Show("Вы подтверждаете правильность введенной информации?", "", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                int j = int.Parse(textBox.Text);
                string str = "Экскурсия в Chateau-de-Chillon" + " " + "кол-во билетов:" + j.ToString() + " " + "Дата:" + " ";

                user.listbox.Add(str);
                NavigationService.Navigate(new Profile(user));
            }
        }

       // private void textBox_TextChanged(object sender, TextChangedEventArgs e)
       // {

        //}
    }
}
