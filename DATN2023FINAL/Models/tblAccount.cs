using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblAccount
    {
        private string username;
        private string password;
        private string e_ID;
        private int permission;
        private bool suppended;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string E_ID { get => e_ID; set => e_ID = value; }
        public int Permission { get => permission; set => permission = value; }
        public bool Suppended { get => suppended; set => suppended = value; }
        public tblAccount()
        {

        }
    }
}
