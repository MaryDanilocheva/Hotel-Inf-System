using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace Hotel_Inf_System2
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
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

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
        XmlSerializer ser =
                          new XmlSerializer(typeof(List<User>));
        List<User> mas = new List<User>();
        private void enter_Click(object sender, RoutedEventArgs e)
        {

          //  string path = "checkin1.txt";
            TextReader reader = new StreamReader("checkin1.txt");
            mas = (List<User>)ser.Deserialize(reader);
            reader.Close();
            int t = 0;
            User newuser = null;
            foreach (User p in mas)
                if (int.Parse(textBoxlogin.Text) != p.Room)
                {
                    t++;
                }
                else { newuser = p; }
            {
                if (int.Parse(textBoxlogin.Text) == newuser.Room && int.Parse(textBoxpassword.Text) == newuser.Reserv)
                {
                    //if (newworker.Profession == "Директор")
                    //{ this.NavigationService.Navigate(new DirectorsPage(newworker.Name)); }
                    
                    NavigationService.Navigate(new Profile(newuser));
                }
                else
                {
                    MessageBox.Show("Неверно введен логин или пароль", "Ошибка", MessageBoxButton.OK);
                }
                //User user = new User();
                //string[] readText = File.ReadAllLines(path);
                //for (int i = 3; i < readText.Length; i += 5)
                //{
                //    if (readText[i] == textBoxlogin.Text)
                //    {
                //        if (readText[i + 1] == textBoxpassword.Text)
                //        {

                //            user.LastName = readText[i - 3];
                //            user.FirstName = readText[i - 2];
                //            user.OtchName = readText[i - 1];
                //            user.Room = int.Parse(readText[i]);
                //            user.Reserv = int.Parse(readText[i + 1]);


                //            NavigationService.Navigate(new Profile(user));
                //        }
                //    }


                //Login1 w1 = new Login1();
                //w1.Show();
            }

            //  private void textBox_TextChanged(object sender, TextChangedEventArgs e)
            //{

            //    }



        }
    }
}
