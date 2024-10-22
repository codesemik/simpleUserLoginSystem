namespace loginSystem
{
    class loginSystem
    {
        public static void Main(String[] args)
        {
            String trueUser = "admin";
            String truePassword = "12345";

            String enteredUser, enteredPassword;
            Console.Write("User Name: ");
            enteredUser = Console.ReadLine();

            Console.Write("Password: ");
            enteredPassword = Console.ReadLine();

            if (enteredUser == trueUser && enteredPassword==truePassword)
            {
                Console.WriteLine("Successfully logged in!");
            }
            else
            {
                Console.WriteLine("Incorrect Login");
            }

            Console.ReadKey();
        }
    }
}
