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
using System.IO;
using System.Windows.Navigation;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hotel_Inf_System2
{
    /// <summary>
    /// Interaction logic for TicketRochers.xaml
    /// </summary>
    public partial class TicketRochers : Page
    {
        User user;
        public TicketRochers(User h)
        {
            user = h;
            InitializeComponent();


        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                i = 1;
            }
            else
            {
                i = 2;
            }

        }
        int i;
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {


            List<User> users = new List<User>();
            var result = MessageBox.Show("Вы подтверждаете правильность введенной информации?", "", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                int j = int.Parse(textBox.Text);
                 string str = "Экскурсия в Rochers-de-Naye" + " " + "кол-во билетов:" + j.ToString() + " " + "Дата:" + " " + "Билеты класса:" + i.ToString();
                
                user.listbox.Add(str);
                NavigationService.Navigate(new Profile(user));
                //     BinaryFormatter formatter = new BinaryFormatter();


                //using (FileStream fs = new FileStream("../../base.dat", FileMode.OpenOrCreate))
                // {
                //     formatter.Serialize(fs, users);
                // }


                //NavigationService.GoBack();
                //StreamWriter textFileticket = new StreamWriter(@"C:\Users\Nik\Desktop\" + user.FirstName.ToString() + user.LastName.ToString()+ ".txt");
                //     {
                //("Экскурсия в Rochers-de-Naye" + " " + "кол-во билетов:" + j +" " + "Дата:" + " "+  "Билеты класса:" + i);
                // textFileticket.Close();
                //}
            }
            else if (result == MessageBoxResult.Cancel)
            {

            }
            else if (result == MessageBoxResult.No)
            {
                // this.Close();
            }
        }
    }

}