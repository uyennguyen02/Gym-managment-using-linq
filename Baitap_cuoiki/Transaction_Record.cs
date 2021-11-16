using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_cuoiki
{
    class Transaction_Record
    {
        public int trans_ID { get; set; }
        public string trans_name { get; set; }
        public int amount { get; set; }
        public DateTime? date { get; set; }
        public client_member client_ { get; set; }
        public Transaction_Record(int trans_ID, string trans_name,int amount,DateTime date, client_member client_)
        {
            this.trans_ID = trans_ID;
            this.trans_name = trans_name;
            this.amount = amount;
            this.date = date;
            this.client_ = client_;
        }
        public Transaction_Record(Transaction_Record ts)
        {
            trans_ID = ts.trans_ID;
            trans_name = ts.trans_name;
            amount = ts.amount;
            date = ts.date;
            client_ = ts.client_;
        }
    }
}
