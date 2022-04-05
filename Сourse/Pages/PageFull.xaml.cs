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
    /// Логика взаимодействия для PageFull.xaml
    /// </summary>
    public partial class PageFull : Page
    {
        private Product cash { get; set; }
        public PageFull(Product product)
        {
            InitializeComponent();

            Img.Source = product.Img;
            TxbDesc.Text = product.Description;
            TxbName.Text = product.Name;
            TxbMaterial.Text = product.Material.Name;
            TxbColor.Text = product.Color.Name;
            TxbCost.Text = product.Cost.ToString();
            cash = product;
        }

        private void BtnBasket_Click(object sender, RoutedEventArgs e)
        {
            ProductClass.product.FirstOrDefault(x=>x.Id == cash.Id).IsBasket = true;
            ProductClass.busket += cash.Cost;
            PageClass.frmMain.GoBack();
        }
    }
}
