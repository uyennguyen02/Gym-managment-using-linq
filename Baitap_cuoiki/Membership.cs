using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_cuoiki
{
    enum Status
    {
        Conhoatdong, hethoatdong
    }
    class Membership
    {
        public int mem_ID { get; set; }
        public Status status { get; set; }
        public DateTime? date { get; set; }
        public client_member client_ { get; set; }

        public Membership(int mem_ID,Status status,DateTime date, client_member client_)
        {
            this.mem_ID = mem_ID;
            this.status = status;
            this.date = date;
            this.client_ = client_;
        }
        public Membership(Membership ms)
        {
            mem_ID = ms.mem_ID;
            status = ms.status;
            date = ms.date;
            client_ = ms.client_;
        }
    }
}
