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
using System.Xml.Serialization;

namespace Hotel_Inf_System2
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void buttoncheckin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RegUser.xaml", UriKind.Relative));
        }
        XmlSerializer ser =
                          new XmlSerializer(typeof(List<User>));
        List<User> mas = new List<User>();
        private void buttondelete_Click(object sender, RoutedEventArgs e)
        {
            
            
            int i = listBox.SelectedIndex;
            listBox.Items.RemoveAt(i);
            mas.RemoveAt(i);
            TextWriter writer = new StreamWriter("checkin1.txt");
            ser.Serialize(writer, mas);
            writer.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            TextReader reader = new StreamReader("checkin1.txt");
            mas = (List<User>)ser.Deserialize(reader);
            reader.Close();
            foreach (User us in mas)
            { listBox.Items.Add(us.FirstName + " " + us.LastName + " " + us.OtchName); }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int i = listBox.SelectedIndex;
            foreach (User us in mas)
            {
                mas.FindIndex(i.Equals);

            }
        }
    }
}
