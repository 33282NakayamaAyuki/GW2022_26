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
using System.Windows.Shapes;

namespace WantList
{
    /// <summary>
    /// EditWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class EditWindow : Window
    {

        WantList.infosys202225DataSet infosys202225DataSet;

        WantList.infosys202225DataSetTableAdapters.WantListTableAdapter infosys202225DataSetWantListTableAdapter;

        System.Windows.Data.CollectionViewSource wantListViewSource;

        DataRowView selectedItem;

        public EditWindow(DataRowView selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
            AddCombobox();
            editPriority.SelectedItem = selectedItem[4].ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            infosys202225DataSet = ((WantList.infosys202225DataSet)(this.FindResource("infosys202225DataSet")));
            // テーブル CarReport にデータを読み込みます。必要に応じてこのコードを変更できます。
            infosys202225DataSetWantListTableAdapter = new WantList.infosys202225DataSetTableAdapters.WantListTableAdapter();
            infosys202225DataSetWantListTableAdapter.Fill(infosys202225DataSet.WantList);

            editName.Text = selectedItem[1].ToString();
            editMoney.Text = selectedItem[2].ToString();
            editPlace.Text = selectedItem[3].ToString();
            editDate.Text = selectedItem[5].ToString();
            editMemo.Text = selectedItem[6].ToString();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //データベース更新
            selectedItem[1] = editName.Text;
            selectedItem[2] = editMoney.Text;
            selectedItem[3] = editPlace.Text;
            selectedItem[5] = editDate.Text;
            selectedItem[6] = editMemo.Text;
            infosys202225DataSetWantListTableAdapter.Update(infosys202225DataSet.WantList);
            this.Close();
        }

        public void AddCombobox()
        {
            editPriority.Items.Add("☆☆☆☆☆");
            editPriority.Items.Add("☆☆☆☆");
            editPriority.Items.Add("☆☆☆");
            editPriority.Items.Add("☆☆");
            editPriority.Items.Add("☆");
        }
    }
}
