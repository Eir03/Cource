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

namespace Сourse.Pages.EditPge
{
    /// <summary>
    /// Логика взаимодействия для PageCatalog.xaml
    /// </summary>
    public partial class PageCatalog : Page
    {
        public PageCatalog()
        {
            InitializeComponent();
            CategoryList.ItemsSource = Odb.entities.ProductType.ToList();
        }

        private void Img_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PageClass.frmMain.Navigate(new PageProduct((int)((Image)sender).Tag));
        }
    }
}
