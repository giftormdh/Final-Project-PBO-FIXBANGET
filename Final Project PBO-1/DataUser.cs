using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_PBO_1
{
    public class DataUser
    {
        public int id; 
        public string name;
        public string email;
        public string username;
        public string password;
        public List<string> history;

        public DataUser()
        {

        }

        public DataUser (int id, string name, string email, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.username = username;
            this.password = password;
        }
        
        public DataUser (List<string> history)
        {

        }
    }

    

}
