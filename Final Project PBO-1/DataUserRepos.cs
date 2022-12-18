using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_PBO_1
{
    public class DataUserRepos
    {
        public List<DataUser> dataUsers = new List<DataUser>()
        {
            new DataUser(1, "admin", "admin@gmail.com", "admin", "admin")
        };

        public List<DataUser> GetAllUsers()
        {
            return dataUsers;
        }

        public DataUser GetUserByID(int id)
        {
            DataUser dataUser = new DataUser();

            foreach(DataUser user in dataUsers)
            {
                if (user.id == id)
                {
                    dataUser = user;
                }
            }
            return dataUser;
        }
    }
}
