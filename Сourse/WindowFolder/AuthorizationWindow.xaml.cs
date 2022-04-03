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
using Сourse.BD;
using Сourse.Classes;
using Сourse.Pages;

namespace Сourse.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            Odb.entities = new Eir_CourceEntities();
            PageClass.frmAuthorization = Frm;
            PageClass.frmAuthorization.Navigate(new PageAuzhorization());
        }
    }
}
