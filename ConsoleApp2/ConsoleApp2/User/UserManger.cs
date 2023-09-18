
    public class UserManger
    {
        private const int V = 1;
        private User[] users;
        public UserManger()
        {
            users = new User[1]
            {
            new User(){Id=1,  Name="Ahmed"}
            };
        }
        public User[] Get()
        {
            return users;
        }
    }

