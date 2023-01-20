using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantList
{
    class Want
    {
        [System.ComponentModel.DisplayName("名前")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("値段")]
        public int Price { get; set; }
        [System.ComponentModel.DisplayName("購入場所")]
        public string PurchasePlace { get; set; }
        [System.ComponentModel.DisplayName("優先度")]
        public string Priority { get; set; }
        [System.ComponentModel.DisplayName("記録日")]
        public DateTime RegistarDate { get; set; }
        [System.ComponentModel.DisplayName("メモ")]
        public string Memo { get; set; }

    }
}