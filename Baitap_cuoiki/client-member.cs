using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_cuoiki
{
    class client_member
    {   
        public int client_ID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool gender { get; set; }
        public string address { get; set; }
        public int age { get; set; }  

        public client_member(int client_ID, string firstname, string lastname, bool gender, int age)
        {
            this.client_ID = client_ID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.age = age;
        }
        public client_member(client_member cm)
        {
            client_ID = cm.client_ID;
            firstname = cm.firstname;
            lastname = cm.lastname;
            gender = cm.gender;
            address = cm.address;
            age = cm.age;
        }
    }
}
