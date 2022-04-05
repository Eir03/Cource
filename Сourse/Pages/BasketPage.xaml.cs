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
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        public BasketPage()
        {
            InitializeComponent();
            if (ProductClass.product != null)
            {
                CategoryList.ItemsSource = ProductClass.product.Where(x=>x.IsBasket == true);
                TbCost.Text = "ИТОГО " + ProductClass.busket.ToString();
            }
        }

        private void BtnF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TbCost.Text = "ИТОГО ";
                foreach (var item in ProductClass.product.Where(x => x.IsBasket == true))
                {
                    item.IsBasket = false;
                }
                ProductClass.busket = 0;
                PageClass.frmMain.Navigate(new BasketPage());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
