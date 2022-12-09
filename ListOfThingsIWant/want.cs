using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfThingsIWant {
    class want {
        public string Name { get; set; }
        public int Price { get; set; }
        public string PurchasePlace { get; set; }
        public PriorityGroup Priority{get;set;}

        public string Group
        {
            get
            {
                string groups = "";
                foreach (PriorityGroup group in ListGroup)
                {
                    groups += "[" + group + "]";
                }
                return groups;
            }
        }
        public List<PriorityGroup> ListGroup { get; set; }


        public enum PriorityGroup {
                a,
                aaaaa,
                aaaa,
                aaa,
                aa,
        }
    }
}
