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
using Сourse.Classes;

namespace Сourse.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAuzhorization.xaml
    /// </summary>
    public partial class PageAuzhorization : Page
    {
        public PageAuzhorization()
        {
            InitializeComponent();
        }

        private void BtnSign_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TbReg_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PageClass.frmAuthorization.Navigate(new PageRegistration());
        }
    }
}
