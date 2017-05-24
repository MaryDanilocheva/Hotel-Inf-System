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

namespace Hotel_Inf_System2
{
    /// <summary>
    /// Логика взаимодействия для Login1.xaml
    /// </summary>
    public partial class Login1 : Page
    {
        public Login1()
        {
            InitializeComponent();
        }

       

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string path = @"D:\checkin1.txt";
            
            string[] readText = File.ReadAllLines(path);
            for (int i = 3; i < readText.Length; i+=5)
            {
                if (readText[i] == textBoxFio.Text)
                {
                    if (readText[i + 1] == textBox2.Text)
                    {
                       
                        User user = new User();
                        Profileinf prof = null;
                        user.LastName = readText[i - 3];
                        user.FirstName = readText[i - 2];
                        user.OtchName = readText[i - 1];
                        user.Room = int.Parse(readText[i]);
                        user.Reserv = int.Parse(readText[i + 1]);

                        NavigationService.Navigate(new Profile(user,prof));

                        //    StreamWriter textFile = new StreamWriter(@"D:\" + user.FirstName.ToString() + user.LastName.ToString() + ".txt");
                        //  //  string patha = (@"C:\Users\Nik\Desktop\" + user.Room.ToString() + ".txt");
                        //   // using //(StreamWriter sw1 = File.CreateText(patha))
                        //    {
                        //        textFile.WriteLine(user.LastName + " " + user.FirstName + " " + user.OtchName);
                        //        textFile.Close();
                    }
                }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль!");
                    }
                }
            }
           //this.Close();
        }
    }

