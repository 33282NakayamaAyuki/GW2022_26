using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ListWant {
    /// <summary>
    /// AddWantList.xaml の相互作用ロジック
    /// </summary>
    public partial class AddWantList : Window {
        BindingList<Want> listWants = new BindingList<Want>();

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

            Want newWant = new Want()
            {
                Name = productName.Text,
                Price = int.Parse(price.Text),
                PurchasePlace = purchasePlace.Text,
                Priority = priority.Text,
                RegistarDate = DateTime.Now,
                Memo = memo.Text,
            };

            listWants.Add(newWant);

            WantListDenote frm = new WantListDenote();
            frm.Show();
            this.Hide();
        }   
    }
}
