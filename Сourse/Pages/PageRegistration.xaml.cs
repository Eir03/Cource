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
using Сourse.Classes;

namespace Сourse.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void TbBack_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PageClass.frmAuthorization.GoBack();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            PageClass.frmAuthorization.Navigate(new PageVerification(TxbEmail.Text));
        }
    }
}
