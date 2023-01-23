using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
    /// AddWantList.xaml の相互作用ロジック
    /// </summary>
    public partial class AddWantList : Window
    {
        WantList.infosys202225DataSet infosys202225DataSet;

        WantList.infosys202225DataSetTableAdapters.WantListTableAdapter infosys202225DataSetWantListTableAdapter;

        public AddWantList()
        {
            InitializeComponent();
            AddCombobox();
            priority.SelectedItem = "☆☆☆☆☆";
        }

        private void priority_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        public void AddCombobox()
        {
            priority.Items.Add("☆☆☆☆☆");
            priority.Items.Add("☆☆☆☆");
            priority.Items.Add("☆☆☆");
            priority.Items.Add("☆☆");
            priority.Items.Add("☆");
        }

        private void addList_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(productName.Text))
            {
                System.Windows.MessageBox.Show("商品名が入力されていません");
                return;
            }
            try
            {

                DataRow newRow = infosys202225DataSet.WantList.NewRow();
                newRow[1] = productName.Text;
                newRow[2] = int.Parse(price.Text);
                newRow[3] = purchasePlace.Text;
                newRow[4] = priority.Text;
                newRow[5] = DateTime.Now;
                newRow[6] = memo.Text;
                //データセットへ新しいレコードを追加
                infosys202225DataSet.WantList.Rows.Add(newRow);
                //データベース更新
                infosys202225DataSetWantListTableAdapter.Update(infosys202225DataSet.WantList);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            WantListDenote frm = new WantListDenote();
            frm.Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            infosys202225DataSet = ((WantList.infosys202225DataSet)(this.FindResource("infosys202225DataSet")));
            // テーブル CarReport にデータを読み込みます。必要に応じてこのコードを変更できます。
            infosys202225DataSetWantListTableAdapter = new WantList.infosys202225DataSetTableAdapters.WantListTableAdapter();
            infosys202225DataSetWantListTableAdapter.Fill(infosys202225DataSet.WantList);
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Hide();
        }
    }
}