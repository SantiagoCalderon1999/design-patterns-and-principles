using System;

namespace dotNET.Solution
{
    class Program
    {
        private static string VALID_USER_JSON = "{\"name\": \"Randy\", \"email\": \"randy@email.com\", \"address\":\"110 Sugar lane\"}";
        private static string INVALID_USER_JSON = "{\"name\": \"Sam\", \"email\": \"sam@email\", \"address\":\"111 Sugar lane\"}";
        static void Main(string[] args)
        {
            UserController controller = new UserController();
            string response = controller.CreateUser(VALID_USER_JSON);
            if (!response.Equals("Success"))
            {
                throw new Exception("Operation was not successful");
            }
            Console.WriteLine("Valid JSON received response: " + response);

            // Invalid user
            response = controller.CreateUser(INVALID_USER_JSON);
            if (!response.Equals("Error"))
            {
                throw new Exception("Operation was not successful");
            }
            Console.WriteLine("Invalid JSON received response: " + response);
        }
    }
}
