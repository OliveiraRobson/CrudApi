using System;
using System.Collections.Generic;
using System.Text;

namespace CrudBase.Data.Tables
{
    public class User
    {
        public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string passwordCrypto{ get; set; }

    }
}
