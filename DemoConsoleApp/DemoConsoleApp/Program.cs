

namespace DemoConsoleApp
{

    class Program 
    {

        static void Main()
        {
            User user1 = new User("Andrzej", "Wasilewski", "wasyl12@gmail.com");
            User user2 = new User("Mariusz", "Kolonko", "max16@gmail.com");
            User user3 = new User("Grzegorz", "Brzęcz", "brzeczyszczykiewicz@gmail.com");
            User user4 = new User("Mariusz", "Pudzian", "pudzianszef@gmail.com");
            User user5 = new User("Ewa", "Zdrzyzga", "fixewa@gmail.com");
            Calculator calc = new Calculator();

            List<User> userList = new List<User>();

            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);
            userList.Add(user4);
            userList.Add(user5);

            foreach (User user in userList)
            {
                user.Display();
            }

            Console.WriteLine();

            calc.Add(2,2);
            calc.Subtract(6,5);
            calc.Multiply(29,2);
            calc.Divide(15,5);
            calc.Modulo(15,5);
        }

    }

}




