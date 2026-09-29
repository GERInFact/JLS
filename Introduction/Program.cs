namespace Introduction;

class Program
{
    static void Main(string[] args)
    {
        const string SECRET = "ux-1337";
        
        Console.WriteLine("Please enter your name:");
        var userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName}! Please enter your student id:");
        int userId = int.Parse(Console.ReadLine());

        if (userId > 0 && userName == SECRET)
        {
            Console.WriteLine("You have been banned from the server! No access possible.");
        }
        else if (!string.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("You account has been created. 1) Show profile 2) Delete account");

            var userActionSelected = Console.ReadLine();
            if(userActionSelected == "1" && userId > 0)
                Console.WriteLine($"User name: {userName}. Date {DateTime.Now.ToShortDateString()}");
            else if (userActionSelected == "2")
                userName = null;
            

            // example for user action with switch case. In IL Code pretty much the same as if else if
            switch (userActionSelected)
            {
                case "1":
                    Console.WriteLine($"User name: {userName}. Date {DateTime.Now.ToShortDateString()}");
                    break;
                case "2":
                    userName = null;
                    Console.WriteLine($"User name erased: {userName}");
                    break;
            }
        }
        
        
        
      
    }
}