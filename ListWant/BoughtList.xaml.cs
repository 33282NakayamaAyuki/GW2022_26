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
using System.Windows.Shapes;
using WantList;

namespace WantList
{
    /// <summary>
    /// BoughtList.xaml の相互作用ロジック
    /// </summary>
    public partial class BoughtList : Window
    {
        public BoughtList()
        {
            InitializeComponent();
        }


        private void WantList_Click(object sender, RoutedEventArgs e)
        {
            WantListDenote frm = new WantListDenote();
            frm.Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Close();
        }

    }
}