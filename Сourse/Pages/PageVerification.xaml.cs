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
using Сourse.BD;
using Сourse.Classes;

namespace Сourse.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageVerification.xaml
    /// </summary>
    public partial class PageVerification : Page
    {
        private int code;

        public PageVerification(string email)
        {
            InitializeComponent();
            Random rnd = new Random();
            code = rnd.Next(10000, 99999);
            EmailClass.PushEmail(email, "Код для подтверждения почты " + code).GetAwaiter();
        }
        private void TbBack_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PageClass.frmAuthorization.GoBack();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (code == int.Parse(TxbCode.Text))
            {
                MessageBox.Show("Все верно");
            }
        }
    }
}
