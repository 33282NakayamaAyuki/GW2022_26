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
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void createCheckBox_Click(object sender, RoutedEventArgs e)
        {
            Window1 frm = new Window1();
            frm.Show();
        }

        private void wantList_Click(object sender, RoutedEventArgs e)
        {
            Window2 frm = new Window2();
            frm.Show();
        }

        private void boughtList_Click(object sender, RoutedEventArgs e)
        {
            Window3 frm = new Window3();
            frm.Show();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
