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
    /// Interaction logic for RegUser.xaml
    /// </summary>
    public partial class RegUser : Page
    {
        public RegUser()
        {
            InitializeComponent();
        }

        XmlSerializer ser =
                           new XmlSerializer(typeof(List<User>));
        List<User> mas = new List<User>();
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
           
            User user = new User(textBox.Text,textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            mas.Add(user);

            string path = "../../checkin1.txt";
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    ser.Serialize(sw, mas);
                    sw.Close();
                    //sw.WriteLine(user.LastName);
                    //sw.WriteLine(user.FirstName);
                    //sw.WriteLine(user.OtchName);
                    //sw.WriteLine(user.Room);
                    ////sw.WriteLine(user.Reserv);
                }
            }
            else
            {
                TextWriter writer = new StreamWriter("checkin1.txt");
                ser.Serialize(writer, mas);
                writer.Close();
            }
            //user.LastName = textBox.Text;
            //user.FirstName = textBox1.Text;
            //user.OtchName = textBox2.Text;
            //user.Room = int.Parse(textBox3.Text);
            //user.Reserv = int.Parse(textBox4.Text);
            //user.listbox = mas;

            //string path = "../../checkin1.txt";
        
            //if (!File.Exists(path))
            //{

            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        sw.WriteLine(user.LastName);
            //        sw.WriteLine(user.FirstName);
            //        sw.WriteLine(user.OtchName);
            //        sw.WriteLine(user.Room);
            //        sw.WriteLine(user.Reserv);
            //    }
            //}

            //using (StreamWriter sw = File.AppendText(path))
            //{
            //    sw.WriteLine(user.LastName);
            //    sw.WriteLine(user.FirstName);
            //    sw.WriteLine(user.OtchName);
            //    sw.WriteLine(user.Room);
            //    sw.WriteLine(user.Reserv);
            //}

            MessageBox.Show("Пользователь успешно зарегистрирован!");
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
 
