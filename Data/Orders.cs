using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    public class Orders
    {

        public int Id { get; set; }

        public int numberOfOrder { get; set; }

        public string typeOfGoods { get; set; }

        public int weightOne { get; set; }

        public int volumeOfUnit { get; set; }

        public string distance { get; set; }

        public int quantity { get; set; }

        public string name { get; set; }

        public string phoneNumber { get; set; }

        public string status { get; set; } = " в исполнении  ";

    }
}
