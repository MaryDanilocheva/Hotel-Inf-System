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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {User user;
        Profileinf inf;

        public Profile(User id, Profileinf _inf)
        {
            user = id;
            inf = _inf;
            string user1 = id.Name();
            InitializeComponent();
            Profillabel.Content = user1;
            try
            { listBox.Items.Add(inf.Inf); }
            catch { }
            listBox.ItemsSource=user.listbox;
        }
        public Profile(User id)
        {
            user = id;
            InitializeComponent();
            listBox.ItemsSource = user.listbox;
            Profillabel.Content = id.FirstName + " " + id.LastName + " " + id.OtchName + " ";
        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Choose(user));
        }

        XmlSerializer ser =
                        new XmlSerializer(typeof(List<Profileinf>));
        List<Profileinf> mas = new List<Profileinf>();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TextReader reader = new StreamReader("profileinf.txt");
            mas = (List<Profileinf>)ser.Deserialize(reader);
            reader.Close();
            Profileinf inf = new Profileinf(Profillabel.Content.ToString(), listBox.Items.ToString());
            mas.Add(inf);
            //string path = "profileinf.txt";
            //if (!File.Exists(path))
            //{

            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        ser.Serialize(sw, mas);
            //        sw.Close();
            
            //    }
            //}
            //else
            //{
                TextWriter writer = new StreamWriter("profileinf.txt");
                ser.Serialize(writer, mas);
                writer.Close();
           // }
        }
    }
}
