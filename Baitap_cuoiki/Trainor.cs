using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_cuoiki
{
    class Trainor
    {
        public int train_ID { get; set; }
        public string train_name { get; set; }
        public int salary { get; set; }
        public Schedule schedule { get; set; }

        public Trainor(int train_ID, string train_name, int salary, Schedule schedule)
        {
            this.train_ID = train_ID;
            this.train_name = train_name;
            this.salary = salary;
            this.schedule = schedule;
        }
        public Trainor(Trainor tn)
        {
            train_ID = tn.train_ID;
            train_name = tn.train_name;
            salary = tn.salary;
            schedule = tn.schedule;
        }
    }
}
