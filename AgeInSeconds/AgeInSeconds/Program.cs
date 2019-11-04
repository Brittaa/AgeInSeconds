using System;

namespace AgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, please enter your birthdate(YYYY/MM/DD): ");
            string birthday = Console.ReadLine();
            Console.WriteLine($"You are born {birthday}.");

            GetAge(birthday);

        }
        public static void GetAge (string birthday)
        {
            string[] personalData = birthday.Split('/');
            int year = int.Parse(personalData[0]);
            int month = int.Parse(personalData[1]);
            int day = int.Parse(personalData[2]);

            
            DateTime userBirthday = new DateTime(year, month, day);
            

            TimeSpan ages = DateTime.Now - userBirthday;
            var seconds = Math.Round(ages.TotalSeconds);

            Console.WriteLine($"You are {seconds} seconds old.");
        }
    }
}
