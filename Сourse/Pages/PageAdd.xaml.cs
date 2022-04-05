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

namespace Сourse.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        public PageAdd()
        {
            InitializeComponent();
            PageClass.frmAdd = FrmAdd;
            PageClass.frmAdd.Navigate(null);
        }

        private void CmbChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CmbChoice.SelectedIndex)
            {
                case 0:
                    PageClass.frmAdd.Navigate(new PageProduct());
                    break;
                case 1:
                    PageClass.frmAdd.Navigate(new PageCategory());
                    break;
                case 2:
                    PageClass.frmAdd.Navigate(new PageMaterial());
                    break;
                case 3:
                    PageClass.frmAdd.Navigate(new PageColor());
                    break;
                default:
                    break;
            }
        }
    }
}
