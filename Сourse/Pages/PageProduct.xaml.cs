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

namespace Сourse.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {
        private byte[] bytes;
        public PageProduct()
        {
            InitializeComponent();

            CmbCategory.SelectedValuePath = "Id";
            CmbCategory.DisplayMemberPath = "Name";
            CmbCategory.ItemsSource = Odb.entities.ProductType.ToList();

            CmbColor.SelectedValuePath = "Id";
            CmbColor.DisplayMemberPath = "Name";
            CmbColor.ItemsSource = Odb.entities.Color.ToList();

            CmbMaterial.SelectedValuePath = "Id";
            CmbMaterial.DisplayMemberPath = "Name";
            CmbMaterial.ItemsSource = Odb.entities.Material.ToList();
        }

        private void borderRect_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void borderRect_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effects = DragDropEffects.Copy;
        }

        private void borderRect_Drop(object sender, DragEventArgs e)
        {
            try
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data != null)
                {

                    var files = data as string[];
                    if (files.Length > 0)
                    {
                        bytes = File.ReadAllBytes(files[0]);
                        using (var ms = new MemoryStream(bytes))
                        {
                            var image = new BitmapImage();
                            image.BeginInit();
                            image.CacheOption = BitmapCacheOption.OnLoad;
                            image.StreamSource = ms;
                            image.EndInit();
                            WOW.Source = image;
                            borderRect.Background = Brushes.White;
                        }
                    }
                }
            }
            catch (Exception)
            {
                bytes = null;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bytes != null)
                {
                    Product type = new Product()
                    {
                        Name = TxbName.Text,
                        Image = bytes,
                        Description = TxbDescription.Text,
                        IdColor = (int)CmbColor.SelectedValue,
                        IdMaterial = (int)CmbMaterial.SelectedValue,
                        IdType = (int)CmbCategory.SelectedValue,
                        Cost = decimal.Parse(TxbCost.Text)
                        
                    };
                    Odb.entities.Product.Add(type);
                    Odb.entities.SaveChanges();
                    PageClass.frmMain.Navigate(new CatalogPage());
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
