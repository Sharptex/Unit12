using System.Collections.Generic;

namespace UserGreetings
{
    public class Login
    {
        private static List<User> userList = new List<User>() 
        { 
            new User("Alex1", "Alex1", true, Ads.ShowAds), 
            new User("Alex2", "Alex2", false, Ads.ShowAds), 
            new User("Alex3", "Alex3", false, Ads.ShowAds) 
        };

        public static User GetUser(string login)
        {
            User user = userList.Find(x => x.Login == login);

            return user;
        }
    }
}
