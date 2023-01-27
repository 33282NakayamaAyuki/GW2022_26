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
    /// GridViewDetail.xaml の相互作用ロジック
    /// </summary>
    public partial class GridViewDetail : Window
    {

        DataRowView selectedItem;

        public GridViewDetail(DataRowView selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            detailName.Text = selectedItem[1].ToString();
            detailPrice.Text = selectedItem[2].ToString();
            detailPlace.Text = selectedItem[3].ToString();
            detailPriority.Text = selectedItem[4].ToString();
            detailDate.Text = selectedItem[5].ToString();
            detailMemo.Text = selectedItem[6].ToString();
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
