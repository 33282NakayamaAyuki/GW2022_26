using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WantList;
using WantList.infosys202225DataSetTableAdapters;

namespace WantList
{
    /// <summary>
    /// WantListDenote.xaml の相互作用ロジック
    /// </summary>
    public partial class WantListDenote : Window
    {
        WantList.infosys202225DataSet infosys202225DataSet;

        WantList.infosys202225DataSetTableAdapters.WantListTableAdapter infosys202225DataSetWantListTableAdapter;

        System.Windows.Data.CollectionViewSource wantListViewSource;

        public WantListDenote()
        {
            InitializeComponent();
            wantListViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("WantListViewSource")));
            wantListViewSource.View.MoveCurrentToFirst();
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
         
        private void WantListDenote_Loaded(object sender, RoutedEventArgs e)
        {
            infosys202225DataSet = ((WantList.infosys202225DataSet)(this.FindResource("infosys202225DataSet")));
            // テーブル CarReport にデータを読み込みます。必要に応じてこのコードを変更できます。
            infosys202225DataSetWantListTableAdapter = new WantList.infosys202225DataSetTableAdapters.WantListTableAdapter();
            infosys202225DataSetWantListTableAdapter.Fill(infosys202225DataSet.WantList);
        }

        private void deleteList_Click(object sender, RoutedEventArgs e)
        {
            //選択行の取り出し
            DataRowView drv = (DataRowView)wantListViewSource.View.CurrentItem;
            //選択されたレコードの削除
            drv.Delete();
            //データベース更新
            infosys202225DataSetWantListTableAdapter.Update(infosys202225DataSet.WantList);
        }

        private void wantListDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var elem = e.MouseDevice.DirectlyOver as FrameworkElement;
            if (elem != null)
            {
                DataGridCell cell = elem.Parent as DataGridCell;
                if (cell == null)
                {
                    // ParentでDataGridCellが拾えなかった時はTemplatedParentを参照
                    // （Borderをダブルクリックした時）
                    cell = elem.TemplatedParent as DataGridCell;
                }
                if (cell != null)
                {
                    // ここでcellの内容を処理
                    // （cell.DataContextにバインドされたものが入っているかと思います）
                    GridViewDetail frm = new GridViewDetail();
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow frm = new EditWindow();
            frm.Show();
            this.Hide();
        }
    }
}