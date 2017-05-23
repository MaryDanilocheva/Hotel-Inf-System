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

namespace Hotel_Inf_System2
{
    /// <summary>
    /// Interaction logic for Rochers.xaml
    /// </summary>
    public partial class Rochers : Page
    {
        User user;
        public Rochers(User h)
        {
            user = h;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new TicketRochers(user));
        }
    }
}