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
using Сourse.WindowFolder;

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
            MainWindow main = new MainWindow();
            main.Show();
            AuthorizationWindow authorization = Application.Current.MainWindow as AuthorizationWindow;
            if (authorization != null) { authorization.Close(); }

        }

        private void TbReg_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PageClass.frmAuthorization.Navigate(new PageRegistration());
        }
    }
}
