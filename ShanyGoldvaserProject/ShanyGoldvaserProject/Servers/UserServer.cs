using Microsoft.Extensions.Logging;
using ShanyGoldvaserProject.Entities;

namespace ShanyGoldvaserProject.Servers
{
    public class UserServer
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<User> GetUsers() => Users;
        public User GetUsersId(int id)
        {
           return  Users.Find(e => e.Id == id);
                 
        }
        public bool PostUsers(User e)
        {
            Users.Add(e);
            return true;
        }
        public bool PutUsers(int id, User e)
        {
            var index = Users.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                Users[index] = e;
                return true;
            }
            return false;
        }
        public bool DeleteUsers(int id)
        {
            var item = Users.Find(ev => ev.Id == id);
            if (item != null)
            { Users.Remove(item);
                return true;
            }
            return false;  
        }

    }
}
