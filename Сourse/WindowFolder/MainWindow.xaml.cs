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
using Сourse.Pages;
using Сourse.Pages.EditPge;

namespace Сourse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Odb.entities = new Eir_CourceEntities();
            PageClass.frmMain = FrmMain;
            PageClass.frmMain.Navigate(new CatalogPage());
        }

        private void ListMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ListMain.SelectedIndex)
            {
                case 0:
                    PageClass.frmMain.Navigate(new CatalogPage());
                    break;
                case 1:
                    PageClass.frmMain.Navigate(new BasketPage());
                    break;
                case 2:
                    PageClass.frmMain.Navigate(new PageAdd());
                    break;
                case 3:
                    PageClass.frmMain.Navigate(new PageCatalog());
                    break;
                default:
                    break;
            }
        }
    }
}
