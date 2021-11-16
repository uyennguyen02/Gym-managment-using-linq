using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_cuoiki
{
    class Schedule
    {
        public int sched_ID { get; set; }
        public string session { get; set; }
        public string activity { get; set; }
        public DateTime? date { get; set; }
        public string time_start { get; set; }
        public string time_end { get; set; }
        public client_member client_ { get; set; }
        public Trainor trainor { get; set; }
        public Schedule(int sched_ID, string session,string activity,DateTime date,string time_start,string time_end,client_member client_,Trainor trainor)
        {
            this.sched_ID = sched_ID;
            this.session = session;
            this.activity = activity;
            this.date = date;
            this.time_start = time_start;
            this.time_end = time_end;
            this.client_ = client_;
            this.trainor = trainor;
        }
        public Schedule(Schedule sc)
        {
            sched_ID = sc.sched_ID;
            session = sc.session;
            activity = sc.activity;
            date = sc.date;
            time_start = sc.time_start;
            time_end = sc.time_end;
            client_ = sc.client_;
            trainor = sc.trainor;
        }
    }
}
