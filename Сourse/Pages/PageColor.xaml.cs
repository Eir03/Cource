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
    /// Логика взаимодействия для PageColor.xaml
    /// </summary>
    public partial class PageColor : Page
    {
        public PageColor()
        {
            InitializeComponent();
            DG.ItemsSource = Odb.entities.Color.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BD.Color color = new BD.Color()
                {
                    Name = TxbName.Text
                };
                Odb.entities.Color.Add(color);
                Odb.entities.SaveChanges();
                DG.ItemsSource = Odb.entities.Color.ToList();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
