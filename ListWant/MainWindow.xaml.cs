using System;
using System.Collections.Generic;
using System.Data;
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

namespace WantList
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        //WantList.infosys202225DataSet infosys202225DataSet;

        //WantList.infosys202225DataSetTableAdapters.WantListTableAdapter infosys202225DataSetWantListTableAdapter;

        System.Windows.Data.CollectionViewSource wantListViewSource;

        public MainWindow()
        {
            InitializeComponent();
            wantListViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("WantListViewSource")));
            wantListViewSource.View.MoveCurrentToFirst();
        }

        private void addList_Click(object sender, RoutedEventArgs e)
        {
            AddWantList frm = new AddWantList();
            frm.Show();
            this.Close();
        }

        private void wantList_Click(object sender, RoutedEventArgs e)
        {
            WantListDenote frm = new WantListDenote();
            frm.Show();
            this.Close();
        }

        private void boughtList_Click(object sender, RoutedEventArgs e)
        {
            DataRowView drv = (DataRowView)wantListViewSource.View.CurrentItem;
            BoughtList frm = new BoughtList(drv);
            frm.Show();
            this.Close();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void finish_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}