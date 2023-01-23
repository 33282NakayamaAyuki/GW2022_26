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

namespace WantList
{
    /// <summary>
    /// GridViewDetail.xaml の相互作用ロジック
    /// </summary>
    public partial class GridViewDetail : Window
    {
        public GridViewDetail()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WantList.infosys202225DataSet infosys202225DataSet = ((WantList.infosys202225DataSet)(this.FindResource("infosys202225DataSet")));
            // テーブル WantList にデータを読み込みます。必要に応じてこのコードを変更できます。
            WantList.infosys202225DataSetTableAdapters.WantListTableAdapter infosys202225DataSetWantListTableAdapter = new WantList.infosys202225DataSetTableAdapters.WantListTableAdapter();
            infosys202225DataSetWantListTableAdapter.Fill(infosys202225DataSet.WantList);
            System.Windows.Data.CollectionViewSource wantListViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("wantListViewSource")));
            wantListViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WantListDenote frm = new WantListDenote();
            frm.Show();
            this.Hide();
        }
    }
}
