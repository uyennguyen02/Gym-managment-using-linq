using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_cuoiki
{
    class payment
    {
       
        public int payment_ID { get; set; }
      
        public DateTime? date { get; set; }
       
        public int money { get; set; }

        public client_member client_ { get; set; }

        public payment(int payment_ID, DateTime date, int money, client_member client_)
        {
            this.payment_ID = payment_ID;
            this.date = date;
            this.money = money;
            this.client_ = client_;
        }

        public payment(payment pm)
        {
            payment_ID = pm.payment_ID;
            date = pm.date;
            money = pm.money;
            client_ = pm.client_;
        }
    }
}
