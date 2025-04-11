using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    public class cooke
    {
        public Users users { get; set; }
        public void RememberUser(Users user)
        {
            users = user;
            
        }


    }
}
