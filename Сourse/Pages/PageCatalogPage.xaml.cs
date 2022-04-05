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
    /// Логика взаимодействия для PageCatalogPage.xaml
    /// </summary>
    public partial class PageCatalogPage : Page
    {
        int id;
        public PageCatalogPage(int Id)
        {
            InitializeComponent();

            id = Id;

            ProductClass.product = Odb.entities.Product.Where(x=>x.IdType == id).ToList();
            CategoryList.ItemsSource = ProductClass.product;
        }

        private void Img_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PageClass.frmMain.Navigate(new PageFull(ProductClass.product.FirstOrDefault(x => x.Id == (int)((Image)sender).Tag)));
        }

        private void TxbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            CategoryList.ItemsSource = ProductClass.product.Where(x => x.Name.Contains(TxbName.Text));
        }
    }
}
