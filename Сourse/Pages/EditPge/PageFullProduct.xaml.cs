using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PageFullProduct.xaml
    /// </summary>
    public partial class PageFullProduct : Page
    {
        private byte[] bytes;
        private int id;
        public PageFullProduct(Product product)
        {
            InitializeComponent();

            id = product.Id;
            CmbCategory.SelectedValuePath = "Id";
            CmbCategory.DisplayMemberPath = "Name";
            CmbCategory.ItemsSource = Odb.entities.ProductType.ToList();

            CmbColor.SelectedValuePath = "Id";
            CmbColor.DisplayMemberPath = "Name";
            CmbColor.ItemsSource = Odb.entities.Color.ToList();

            CmbMaterial.SelectedValuePath = "Id";
            CmbMaterial.DisplayMemberPath = "Name";
            CmbMaterial.ItemsSource = Odb.entities.Material.ToList();

            TxbName.Text = product.Name;
            TxbDescription.Text = product.Description;
            TxbCost.Text = product.Cost.ToString();
            CmbCategory.Text = product.ProductType.Name;
            CmbColor.Text = product.Color.Name;
            CmbMaterial.Text = product.Material.Name;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var product = Odb.entities.Product.FirstOrDefault(x => x.Id == id);
                product.Name = TxbName.Text;
                product.Description = TxbDescription.Text;
                product.Cost = decimal.Parse(TxbCost.Text);
                product.IdType = (int)CmbCategory.SelectedValue;
                product.IdMaterial = (int)CmbMaterial.SelectedValue;
                product.IdColor= (int)CmbColor.SelectedValue;
                Odb.entities.SaveChanges();
                PageClass.frmMain.Navigate(new CatalogPage());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
