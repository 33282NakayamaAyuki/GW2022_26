using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace ListWant {
    /// <summary>
    /// WantListDenote.xaml の相互作用ロジック
    /// </summary>
    public partial class WantListDenote : Window {
        public WantListDenote()
        {
            InitializeComponent();
            
        }

        private void addList_Click(object sender, RoutedEventArgs e)
        {
            AddWantList frm = new AddWantList();
            frm.Show();
            this.Hide();
        }

        private void boughtList_Click(object sender, RoutedEventArgs e)
        {
            BoughtList frm = new BoughtList();
            frm.Show();
            this.Hide();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Hide();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            SearchCondition frm = new SearchCondition();
            frm.Show();
            this.Hide();
        }
    }
}
