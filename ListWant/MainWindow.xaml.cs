using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
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

namespace ListWant {
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
            AddWantList frm = new AddWantList();
            frm.Show();
            this.Hide();
        }

        private void wantList_Click(object sender, RoutedEventArgs e)
        {
            WantListDenote frm = new WantListDenote();
            frm.Show();
            this.Hide();
        }

        private void boughtList_Click(object sender, RoutedEventArgs e)
        {
            BoughtList frm = new BoughtList();
            frm.Show();
            this.Hide();

        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
