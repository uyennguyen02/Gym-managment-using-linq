using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_cuoiki
{
    class Report
    {
        public int report_ID { get; set; }
        public int total_amount { get; set; }
        public DateTime? date { get; set; }
        public client_member client_ { get; set; }
        public Transaction_Record transaction_ { get; set; }

        public Report(int report_ID, int total_amount, DateTime date, client_member client_, Transaction_Record transaction_)
        {
            this.report_ID = report_ID;
            this.total_amount = total_amount;
            this.date = date;
            this.client_ = client_;
            this.transaction_ = transaction_;
        }
        public Report(Report rp)
        {
            report_ID = rp.report_ID;
            total_amount = rp.total_amount;
            date = rp.date;
            client_ = rp.client_;
            transaction_ = rp.transaction_;
        }
    }
}
