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

namespace ListOfThingsIWant {
    /// <summary>
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Page {
        public Page1()
        {
            InitializeComponent();
        }

        private void createCheckBox_Click(object sender, RoutedEventArgs e)
        {
            Window1 sw = new Window1();
            sw.Show();

        }

        private void wantList_Click(object sender, RoutedEventArgs e)
        {
            var page2 = new Page2();
            NavigationService.Navigate(page2);
        }

        private void boughtList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
