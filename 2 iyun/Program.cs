using System;

namespace _2_iyun
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(Console.ReadLine());
            user1.Password = Console.ReadLine();
            Console.WriteLine(user1.UserName+ " "+ user1.Password);
            
        }
    }
}
