using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace ListOfThingsIWant {
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window {
        public Window1()
        {
            InitializeComponent();
            AddCombobox();
            registarDate.Content = DateTime.Now;

        }

        private void priority_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void openPictureFile_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            try
            {
                //バイナリ形式でシリアル化(保存できるようにしている)
                var bf = new BinaryFormatter();

                using (FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    //逆シリアル化して読み込む
                    //picture.Source = 

                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddCombobox()
        {
            priority.Items.Add("☆☆☆☆☆");
            priority.Items.Add("☆☆☆☆");
            priority.Items.Add("☆☆☆");
            priority.Items.Add("☆☆");
            priority.Items.Add("☆");
        }

        private void deletePictureFile_Click(object sender, RoutedEventArgs e)
        {
            picture.Source = null;
        }

        private void addList_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(productName.Text) && String.IsNullOrWhiteSpace(price.Text))
            {
                MessageBox.Show("氏名と値段が入力されていません");
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




        }
    }
}
