﻿using System;
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
    /// Interaction logic for RegUser.xaml
    /// </summary>
    public partial class RegUser : Page
    {
        public RegUser()
        {
            InitializeComponent();
        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.LastName = textBox.Text;
            user.FirstName = textBox1.Text;
            user.OtchName = textBox2.Text;
            user.Room = int.Parse(textBox3.Text);
            user.Reserv = int.Parse(textBox4.Text);

            string path = @"C:\Users\Nik\Desktop\Hotel Inf System2\checkin1.txt";
        
            if (!File.Exists(path))
            {
               
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(textBox.Text);
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(textBox3.Text);
                    sw.WriteLine(textBox4.Text);
                }
            }
           
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(textBox.Text);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox4.Text);
            }
         
            MessageBox.Show("Пользователь успешно зарегистрирован!");
        }
    }

}
 
