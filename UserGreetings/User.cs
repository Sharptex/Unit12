using System;

namespace UserGreetings
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public delegate void ShowDelegate();
        private readonly ShowDelegate ads;

        public User(string login, string name, bool isPremium, ShowDelegate ads)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
            this.ads = ads;
        }

        public void ShowGreetings()
        {
            Console.WriteLine($"Добро пожаловать, {Name}!");

            if (!IsPremium) 
            {
                ads.Invoke(); 
            }
        }
    }
}
