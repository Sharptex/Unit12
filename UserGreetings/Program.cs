using System;

namespace UserGreetings
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Введите логин: ");
			var login = Console.ReadLine();
			var user = Login.GetUser(login);

            if (user != null) 
			{ 
				user.ShowGreetings(); 
			} 
			else 
			{ 
				Console.WriteLine("Неверный логин!"); 
			}

			Console.ReadKey();
        }
	}
}
