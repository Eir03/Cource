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

namespace Сourse.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMaterial.xaml
    /// </summary>
    public partial class PageMaterial : Page
    {
        public PageMaterial()
        {
            InitializeComponent();
            DG.ItemsSource = Odb.entities.Material.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Material material = new Material()
                {
                    Name = TxbName.Text
                };
                Odb.entities.Material.Add(material);
                Odb.entities.SaveChanges();
                DG.ItemsSource = Odb.entities.Material.ToList();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
